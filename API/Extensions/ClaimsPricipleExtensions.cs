using System;
using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPricipleExtensions
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.Name)
            ?? throw new Exception("Cannot get username form token");

        return username;
    }
    
    public static int GetUserId(this ClaimsPrincipal user)
    {
        var userid = int.Parse(user.FindFirstValue(ClaimTypes.NameIdentifier)
            ?? throw new Exception("Cannot get username form token"));
        
        return userid;
    }
}
