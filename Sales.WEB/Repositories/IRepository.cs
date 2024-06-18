namespace Sales.WEB.Repositories
{
    public interface IRepository
    {
        //Get
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        //Post
        Task<HttpResponseWrapper<object>> Post<T>(string url, T model);
        //Post que devuelve respuesta
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model);

        //Delete
        Task<HttpResponseWrapper<object>> Delete(string url);

        //Put
        Task<HttpResponseWrapper<object>> Put<T>(string url, T model);

        //Put que devuelve una respuesta
        Task<HttpResponseWrapper<TResponse>> Put<T, TResponse>(string url, T model);



    }
}
