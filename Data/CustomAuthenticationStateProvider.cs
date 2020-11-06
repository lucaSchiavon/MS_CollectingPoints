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
       
        private ILocalStorageService _localStorageService;

        public CustomAuthenticationStateProvider( ILocalStorageService localStorageService)
        {
           
            _localStorageService = localStorageService;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            
            var userName = await _localStorageService.GetItemAsync<string>("UserName");
          

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
      
        public async void MarkUserAsLoggedOut()
        {

         
           await _localStorageService.RemoveItemAsync("UserName");
         
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
