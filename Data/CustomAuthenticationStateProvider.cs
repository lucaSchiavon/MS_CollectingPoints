using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MS_CollectingPoints.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        private ILocalStorageService _localStorageService;

        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService, ILocalStorageService localStorageService)
        {
            _sessionStorageService = sessionStorageService;
            _localStorageService = localStorageService;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //int lunghezza = await _sessionStorageService.LengthAsync();
            //var userName = await _sessionStorageService.GetItemAsync<string>("xxx");
            var userName = await _localStorageService.GetItemAsync<string>("UserName");
            //int lunghezza2 = await _sessionStorageService.LengthAsync();
            //var userName = "pippo";

            ClaimsIdentity identity;
            if (userName != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name,userName),
                }, "apiauth_type");
            }
            else
            {
                identity = new ClaimsIdentity();
            }
          
            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }
        public void MarkUserAsAuthenticated(string userName)
        {

            var identity = new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.Name, userName),
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

        }
        //public void MarkUserAsLoggedOut()
        ////{

        //    // _sessionStorageService.RemoveItemAsync("xxx");
       
        //    _sessionStorageService.ClearAsync();
        //    //_sessionStorageService.RemoveItemAsync("xxx");
            

        //    var identity = new ClaimsIdentity();
        //    var user = new ClaimsPrincipal(identity);
        //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        //}
        public async void MarkUserAsLoggedOut()
        {

            // _sessionStorageService.RemoveItemAsync("xxx");
            //int lunghezza = await _sessionStorageService.LengthAsync();
            //await _sessionStorageService.ClearAsync();
           await _localStorageService.RemoveItemAsync("UserName");
            //_sessionStorageService.RemoveItemAsync("xxx");
            //int lunghezza2 = await _sessionStorageService.LengthAsync();

            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
