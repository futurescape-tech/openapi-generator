// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.IApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IDefaultApi : IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;FooGetDefaultResponse&gt;&gt;</returns>
        Task<ApiResponse<FooGetDefaultResponse>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;FooGetDefaultResponse&gt;</returns>
        Task<FooGetDefaultResponse> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object&gt;&gt;</returns>
        Task<ApiResponse<object>> GetCountryWithHttpInfoAsync(string country, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;object&gt;</returns>
        Task<object> GetCountryAsync(string country, System.Threading.CancellationToken? cancellationToken = null);
    }
}

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IApi.IDefaultApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<DefaultApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(ILogger<DefaultApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider, 
            TokenProvider<BearerToken> bearerTokenProvider, 
            TokenProvider<BasicToken> basicTokenProvider, 
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider, 
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        /// <summary>
        /// Logs the api response
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (args.ReceivedAt - args.RequestedAt).TotalSeconds, args.HttpStatus, args.Path);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="FooGetDefaultResponse"/>&gt;</returns>
        public async Task<FooGetDefaultResponse> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<FooGetDefaultResponse> apiResponseLocalVar = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);

            if (apiResponseLocalVar.Content == null)
                throw new ApiException(apiResponseLocalVar.ReasonPhrase, apiResponseLocalVar.StatusCode, apiResponseLocalVar.RawContent);

            return apiResponseLocalVar.Content;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="FooGetDefaultResponse"/>&gt;</returns>
        public async Task<FooGetDefaultResponse> FooGetOrDefaultAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<FooGetDefaultResponse> apiResponseLocalVar = null;
            try 
            {
                apiResponseLocalVar = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return apiResponseLocalVar != null && apiResponseLocalVar.IsSuccessStatusCode
                ? apiResponseLocalVar.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <returns></returns>
        protected virtual void OnFooGet()
        {
            return;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        protected virtual void AfterFooGet(ApiResponse<FooGetDefaultResponse> apiResponseLocalVar)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        protected virtual void OnErrorFooGet(Exception exception, string pathFormat, string path)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="FooGetDefaultResponse"/></returns>
        public async Task<ApiResponse<FooGetDefaultResponse>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                OnFooGet();

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/foo";



                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] { 
                        "application/json" 
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = new HttpMethod("GET");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAtLocalVar, DateTime.UtcNow, httpResponseMessageLocalVar.StatusCode, "/foo", uriBuilderLocalVar.Path));

                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<FooGetDefaultResponse> apiResponseLocalVar = new ApiResponse<FooGetDefaultResponse>(httpResponseMessageLocalVar, responseContentLocalVar);

                        if (apiResponseLocalVar.IsSuccessStatusCode)
                        {
                            apiResponseLocalVar.Content = JsonSerializer.Deserialize<FooGetDefaultResponse>(apiResponseLocalVar.RawContent, _jsonSerializerOptions);
                            AfterFooGet(apiResponseLocalVar);
                        }

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFooGet(e, "/foo", uriBuilderLocalVar.Path);
                throw;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object> GetCountryAsync(string country, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object> apiResponseLocalVar = await GetCountryWithHttpInfoAsync(country, cancellationToken).ConfigureAwait(false);

            if (apiResponseLocalVar.Content == null)
                throw new ApiException(apiResponseLocalVar.ReasonPhrase, apiResponseLocalVar.StatusCode, apiResponseLocalVar.RawContent);

            return apiResponseLocalVar.Content;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="object"/>&gt;</returns>
        public async Task<object> GetCountryOrDefaultAsync(string country, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<object> apiResponseLocalVar = null;
            try 
            {
                apiResponseLocalVar = await GetCountryWithHttpInfoAsync(country, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return apiResponseLocalVar != null && apiResponseLocalVar.IsSuccessStatusCode
                ? apiResponseLocalVar.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        protected virtual string OnGetCountry(string country)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (country == null)
                throw new ArgumentNullException(nameof(country));

            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return country;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="country"></param>
        protected virtual void AfterGetCountry(ApiResponse<object> apiResponseLocalVar, string country)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="country"></param>
        protected virtual void OnErrorGetCountry(Exception exception, string pathFormat, string path, string country)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="country"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public async Task<ApiResponse<object>> GetCountryWithHttpInfoAsync(string country, System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                country = OnGetCountry(country);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/country";

                    MultipartContent multipartContentLocalVar = new MultipartContent();

                    httpRequestMessageLocalVar.Content = multipartContentLocalVar;

                    List<KeyValuePair<string, string>> formParameterLocalVars = new List<KeyValuePair<string, string>>();

                    multipartContentLocalVar.Add(new FormUrlEncodedContent(formParameterLocalVars));

                    formParameterLocalVars.Add(new KeyValuePair<string, string>("country", ClientUtils.ParameterToString(country)));



                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/x-www-form-urlencoded" 
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);
                        
                    httpRequestMessageLocalVar.Method = new HttpMethod("POST");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAtLocalVar, DateTime.UtcNow, httpResponseMessageLocalVar.StatusCode, "/country", uriBuilderLocalVar.Path));

                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<object> apiResponseLocalVar = new ApiResponse<object>(httpResponseMessageLocalVar, responseContentLocalVar);

                        if (apiResponseLocalVar.IsSuccessStatusCode)
                        {
                            apiResponseLocalVar.Content = JsonSerializer.Deserialize<object>(apiResponseLocalVar.RawContent, _jsonSerializerOptions);
                            AfterGetCountry(apiResponseLocalVar, country);
                        }

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetCountry(e, "/country", uriBuilderLocalVar.Path, country);
                throw;
            }
        }
    }
}
