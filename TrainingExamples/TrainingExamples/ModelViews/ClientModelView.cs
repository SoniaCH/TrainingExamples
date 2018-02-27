using System;
using System.Collections.Generic;
using System.Text;
using TrainingExamples.Models;
using TrainingExamples.Views;
using System.Diagnostics;

namespace TrainingExamples.ModelViews
{
    class ClientModelView
    {
        public ClientModelView()
        {
            _client = new ClientModel("Sonia");
        }
        private ClientModel _client;

        public ClientModel Client
        {
            get { return _client; }
        }

        public void SaveChanges()
        {
            Debug.Assert(false, "the name of the client is  updated to {0}", Client.Name);
        }

    }
}
