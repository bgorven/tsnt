T-S-N-T
=======

.Net sample app for TAS
-----------------------

Simple dotnetcore app demonstrating some common TAS operations.

### Orchestration APIs (TenantsController)

Core out calls as documented in the [TAS core-out APIs](http://talentappstore.github.io/tas-core-apis/generated/coreOut.raml.html) Every TAS app should serve all of these APIs, even if they don't have any actions they want to perform in them. When a tenant installs or uninstalls an app, the core calls the preHalts, halts, preStarts, and starts api of every app installed on that tenant, and calls the install or uninstall method of the app that was uninstalled.

### Tenant APIs (AppStatusController and HelloWorldController)

The AppStatusController, mounted at /t/{tenant}/tas/devs/tas/, serves the appStatus api, as documented in the [TAS tenant APIs](http://talentappstore.github.io/tas-tenant-apis/generated/recruitment.raml.html#appStatus). Producing this API lets users open or configure your app from the storefront.

The HelloWorldController, mounted at /t/{tenant}/tas/devs/buddy/, produces private APIs defined on my own developer account (with shortcode 'buddy'), to illustrate the different ways that APIs can be produced or consumed.

#### /helloWorld (source-of-truth)

Source-of-truth means that there can only be one app installed at a tenant that provides this api. Calling SOT apis is simple - you just make a request to tazzy with the tenant shortcode and the api url you are consuming, and tazzy forwards that request to the SOT producer and returns their response.

This api responds with "Hello, {tenant name}".

#### /helloWorld/me (on-behalf-of-candidate)

On-behalf-of apis contain the saml key of a principal who is currently signed in to a tas app. You can use that saml key to request that candidate's details from the core. Tazzy handles logins, and passing tokens from app to app correctly, all you need to do to make an on behalf of call is pass the correct header back to tazzy when you make an api call:

 - 'Tazzy-Saml' when the principal is signed-in to your app
 - 'Authorization' when forwarding on-behalf-of details to another on-behalf api.

This api responds with "Hello, {principal name}".

#### /helloWorld/forApp (non-source-of-truth)

From the producer's side, there's no difference between a source-of-truth api and a non-SOT api, but non-SOT apis mean extra work for the consuming app, as there may be multiple producers installed at a tenant, and you typically need to contact each one.

This api responds with "Hello, {consuming app}".

### WebController

#### Index

Simple html page showing the results of calls to each of the APIs. This app is configured to consume each of the /helloWorld apis that it produces, just for the sake of this demo.

This page can be viewed at https://tsnt.communityapps.talentappstore.com/t/buddy/, or by opening the app from the storefront after installing it with the following token:

```
eyJhbGciOiJSUzUxMiJ9.dHNudA.Fm0_uwmZfx6y3yNqL-3YkGZ7naLE3UpJFPpPgvpz6qW8FgnA2cwIXE0xJ-bSzOkCPoJdKfuGe3TKlXAkimyiQrneY3AD3_UosrYuVAFHVkHCcpLNUvGh_TSMwOvBnXdLYb37vd_m7kpUYYNxgRx_xYGobVI7T9DnRM_92-Y9vUvO57xq2FCTkOGwUE78Zm9Xebg3Webq6-NnkaFuFBGW95UrqGcxf8giYOGCsFrJEVbeEP9CgmV1x6T0iO8EvxAw0p0KP1KtVMSEQGRCUFYf4cQeJAL2Ta7HBCCydUJHZ1ismrLz-R_tR5j8lf29JoQf51Tc6Zkj7WovmzFkruO7eA
```

 As this app has the 'candidate' principal type, and the path this page is mounted at is not in the list of 'SSO unprotected pages', you will be required to sign in as a candidate to view this page.

#### AfterLogout

If you click the 'sign out' link on the index page, you will be taken through the tazzy sign-out process, after which you will be sent to /t/{tenant}/tas/logout. This page displays a simple message to confirm that the signout was successful, and it is recommended that every TAS app with protected pages provides a page at this path.

### Other classes

#### TasMiddleware (very important, unless you are self-hosting tazzy)

Returns 401 for any request that doesn't have a tazzy-secret header matching the hmac key the app is configured with. This prevents the back end server from being accessed, except by tazzy.

#### TokenJwtBinderProvider

Extracts the JWT token from the auth header, which will be present for any API requests. You can add TokenJwt as a controller method parameter to find details about the request.

#### TasConfig

Holds the app shortcode, secret, and optionally the tazzy url to use when making api calls.

#### TasClient

I put all of the complexity here (and then some), so that my controller methods would look nice and clean.

### Running the app

As the apis this app consumes are private, you would need to create your own versions of the apis at the [developer site](https://developer.talentappstore.com), and modify the code to use those instead of my ones. Then create an app that both consumes and produces each api, and produces /appStatus (non-sot), with the 'candidate' principal type, add each static file in wwwroot to the 'SSO unprotected pages' in the tazzy settings, and set the 'back end server' to the url your instance is hosted at (you can deploy to http://<app_name>.azurewebsites.net with a single click, [plus a bit of typing](https://docs.microsoft.com/en-nz/azure/app-service/app-service-web-get-started-dotnet)).


### Contact details

https://github.com/bgorven/tsnt