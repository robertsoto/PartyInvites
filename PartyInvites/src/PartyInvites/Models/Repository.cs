using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses
        {
            get { return responses; }
        }

        public static void AddResponse (GuestResponse response)
        {
            responses.Add(response);
        }


//        Page 33 -- The Repository class and its members are static , which will make it easy for me 
//        to store and retrieve data from different places in the application.
//        MVC provides a more sophisticated approach for defining
//        common functionality, called dependency injection , which I describe in Chapter 18 , 
//        but a static class is a good way to get started for a simple application like this one.

    }
}
