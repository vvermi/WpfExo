using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExo.Bindings
{
    internal class Bindings_VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        #region Exo1 
        private string _test = "Hello !";
        public string Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("Test"); // Notifie la vue que la propriété "Test" a été modifié
            }
        }
        #endregion

        #region Exo2 (avec 2 Binds)
        private string _test2 = "Hello !";
        public string Test2
        {
            get { return _test2; }
            set
            {
                Test = value.ToUpper();
                _test2 = value;
                OnPropertyChanged("Test2"); // Notifie la vue que la propriété "Test" a été modifié
            }
        }
        #endregion

        #region Exo3 (Button)
        public ICommand EditText
        {
            get
            {
                return new RelayCommand(param =>
                {
                    Test = "World";
                });
            }
        }
        #endregion

        #region Exo4 (Liste string)
        private ObservableCollection<string> _listeString = new ObservableCollection<string> { "TOTO", "FOO", "BAR" };

        public ObservableCollection<string> ListeString
        {
            get { return _listeString; }
            set { _listeString = value; }
        }
        #endregion

        #region Exo5 (3 buttons)
        public ICommand AddElement
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeString.Add("Titi");
                });
            }
        }
        public ICommand ModElement1
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeString[0] = "Blabla";
                });
            }
        }
        public ICommand DelElement1
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeString.RemoveAt(0);
                },
                param => ListeString.Count() > 0);
            }
        }
        #endregion

        #region Exo6 (Liste de Messages)


        private ObservableCollection<cls_Message> _listeMessage = new ObservableCollection<cls_Message>() { new cls_Message(1, "Mock message", "from me", DateTime.Now) };

        public ObservableCollection<cls_Message> ListeMessage
        {
            get { return _listeMessage; }
            set { _listeMessage = value; }
        }
        #endregion

        #region Exo7 (Buttons sur Message)
        public ICommand AddMessage
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeMessage.Add(new cls_Message(ListeMessage.Count(), "Ajout" + ListeMessage.Count(), "Me", DateTime.Now));
                });
            }
        }
        public ICommand ModMessage1
        {
            get
            {
                return new RelayCommand(param =>
                {
                    cls_Message myMessage = ListeMessage[0];
                    myMessage.MyMessage = "Updated !";
                    myMessage.MyDate = DateTime.Now;
                    ListeMessage[0] = myMessage;
                },
                param => ListeMessage.Count() > 0);
            }
        }
        public ICommand DelMessage1
        {
            get
            {
                return new RelayCommand(param =>
                {
                    ListeMessage.RemoveAt(0);
                },
                param => ListeMessage.Count() > 0);
            }
        }
        #endregion

        #region Bonus (SelectedIndex)
        public int MySelectedMessageIndex { get; set; }

        public RelayCommand DelSelectedMessage => new RelayCommand(execute => ListeMessage.RemoveAt(MySelectedMessageIndex), canExecute  => ListeMessage.Count() > 0);

        #endregion

        #region Bonus 2 (Converter + Button sans interface)
        private int _randomInt = 0;

        public int RandomInt
        {
            get {            
                
                return _randomInt; }
            set { _randomInt = value;
                OnPropertyChanged("RandomInt");
            }
        }

        public RelayCommand cmdChangeNumber => new RelayCommand(execute =>
        {
            RandomInt = new Random().Next(20);
        });

        #endregion

        #region TestBindingHeight
        
        private Object  _myHeight;

        public Object MyHeight
        {
            get { return _myHeight; }
            set { _myHeight = value;
                OnPropertyChanged("MyHeight");
            }
        }

        #endregion

        #region Template et Style

        public RelayCommand DelMessageTemplate => new RelayCommand(execute => ListeMessage.Remove((cls_Message)execute), canExecute => ListeMessage.Count() > 0);



        #endregion

        #region (Images)

        //TODO : faire une classe pour gerer les bindings dans le context de la listview ...

        private ObservableCollection<string> _listeImage = new ObservableCollection<string>() { "https://static-cse.canva.com/blob/996500/Sanstitre.jpg", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT04EwKQlzGTZ0fYeKbTn5OVoBG0NJAyzR1WxXY6rEeN4cyKQiy6rEG2KtUMopj22lgRQ&usqp=CAU", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSeExeIUJfIxQJSXX9nC03mE10lhHutFNrQR_wjORjNWmH8ZSEDA7kyTBLmn9dkMzezD2s&usqp=CAU" };
        
        public ObservableCollection<string> ListeImage
        {
            get { return _listeImage; }
        }

        #endregion



    }
}
