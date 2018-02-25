using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Globalization;
using System.Threading.Tasks;
using Tas.Core.TokenJwt;

namespace Tas.Server
{
    public class TokenJwtBinderProvider : IModelBinderProvider
    {
        private readonly string _secret;
        public TokenJwtBinderProvider(string secret)
        {
            _secret = secret;
        }
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(TokenJwt))
            {
                return new TokenJwtBinder(_secret);
            }

            return null;
        }
    }

    public class TokenJwtBinder : IModelBinder
    {
        private readonly IJsonSerializer serializer = new JsonNetSerializer();
        private readonly IDateTimeProvider provider = new UtcDateTimeProvider();
        private readonly IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
        private readonly IJwtValidator validator;
        private readonly IJwtDecoder decoder;
        private readonly string _secret;

        public TokenJwtBinder(string secret)
        {
            validator = new JwtValidator(serializer, provider);
            decoder = new JwtDecoder(serializer, validator, urlEncoder);
            _secret = secret;
        }
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var header = bindingContext.HttpContext.Request.Headers["Authorization"];

            if (header.Count != 1)
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, $"Found {header.Count} authorization headers, expected 1.");
                return Task.CompletedTask;
            }

            var token = header[0].StartsWith("Bearer ") ? header[0].Substring("Bearer ".Length) : header[0];
            var result = decoder.DecodeToObject<TokenJwt>(token, _secret, false);
            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}