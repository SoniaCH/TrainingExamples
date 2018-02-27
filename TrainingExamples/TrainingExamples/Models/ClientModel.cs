using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace TrainingExamples.Models
{
    class ClientModel:INotifyPropertyChanged
    {   //the properties of the class
        string name;
       // the constructeur of the class
        public ClientModel(string name) {
            this.name = name;
        }
        // geting and setting the class
        public string Name {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
                }
        }

        #region  the INotifyPropertyChanged methods that we need to implement : we only have an event handler to implement
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {

            if (PropertyChanged!=null) {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
