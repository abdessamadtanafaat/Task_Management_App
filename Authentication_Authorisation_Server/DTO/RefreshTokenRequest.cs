﻿namespace Authentication_Authorisation.Models;

public class RefreshTokenRequest
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }

    public RefreshTokenRequest(string token, string refreshToken)
    {
        Token = token;
        RefreshToken = refreshToken; 
    }
}