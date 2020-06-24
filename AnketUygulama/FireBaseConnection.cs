using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace AnketUygulama
{
    public class FireBaseConnection
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "40dXxk62WrawbXj5wnRk8JfyJiPwKK1rnASofdLP",
            BasePath = "https://vize-a40f4.firebaseio.com/"

        };
        public IFirebaseClient client;
        public FirebaseResponse response;
    }
}
