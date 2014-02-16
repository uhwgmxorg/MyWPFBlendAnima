using System;
using System.ComponentModel;

namespace MyWPFBlendAnima
{
	public class MainViewModel : INotifyPropertyChanged
	{
		public MainViewModel()
		{
			// Insert code required on object creation below this point.
		}
		
        private bool start1;
        public bool Start1
        {
            get
            {
                return this.start1;
            }
            set
            {
                this.start1 = value;
                this.NotifyPropertyChanged("Start1");
            }
        }
		
        /// <summary>
        /// Button1
        /// </summary>
        public void Button1()
        {
            Start1 = !Start1;
        }
		
		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged(String info)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(info));
			}
		}
		#endregion

	}
}