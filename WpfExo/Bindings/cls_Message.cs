using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfExo.Bindings
{
    internal class cls_Message : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    
		private int _myVar;

		public int MyVar
		{
			get { return _myVar; }
			set { _myVar = value; }
		}

        public string MyVarTemplate
        {
            get { return $"{_myVar, -3}"; }
            
        }

        private string _myMessage;

		public string MyMessage
		{
			get { return _myMessage; }
			set { _myMessage = value; }
		}

        public string MyMessageTemplate
        {
            get { return $"{_myMessage, -100}"; }
            set { _myMessage = value; }
        }

        private string _myEmetteur;

        public string MyEmetteur
        {
            get { return _myEmetteur; }
            set { _myEmetteur = value; }
        }
        public string MyEmetteurTemplate
        {
            get { return $"{_myEmetteur, -30}"; }
            set { _myEmetteur = value; }
        }

        private DateTime _myDate;

		public DateTime MyDate
		{
			get { return _myDate; }
			set { _myDate = value; }
		}

		public cls_Message(int myVar, string myMessage, string myEmetteur, DateTime myDate)
		{
			MyMessage = myMessage;
			MyVar = myVar;
			MyEmetteur = myEmetteur;
			MyDate = myDate;

		}
        public override string ToString()
        {
			return $"{MyVar,-5} {MyDate} {MyEmetteur, -30} {MyMessage}";

		}
    }
}
