// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace Firebase.Rest.Authentication.Requests
{
    [Serializable]
    internal class IdTokenRequest
    {
        public IdTokenRequest(string idToken)
        {
            IdToken = idToken;
        }

        public string IdToken { get; protected set; }
    }
}
