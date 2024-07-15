# WebApiSample

~~Minimal~~ sample of how to create an API-spec-first Web Application with ASP.NET Core powered by OpenAPI specification.

## Specification
The specification resides in the `Api` directory.

## Code Generation
In the `Api` directory, through `package.json` and configured by `openapitools.json` the generator can be invoked. The Projects `WebApiSample.Api` and `WebApiSample.Api.Model` will be generated.

Generated Code is not checked into VCS, so it will have to be generated before building the project. This way the API will always be up-to-date with the specification.

## Implementing the API
`WebApiSample.Api` is generated as a library, so the controllers are being generated as abstract classes. You, the developer, can then implement these controllers in your application.