using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiTestSample.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UiTestSample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListNote : ContentPage
	{
		public ListNote ()
		{
			InitializeComponent ();
		}
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Note> _test;

        public void SQLiteDbTest()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        }

        protected async override void OnAppearing()
        {
            await _connection.CreateTableAsync<Note>();
            var abc = await _connection.Table<Note>().ToListAsync();
            _test = new ObservableCollection<Note>(abc);
            mylistview.ItemsSource = _test;
            base.OnAppearing();
        }

        void OnAdd(object sender, System.EventArgs e)
        {
            var test = new Note { Title = Title.Text, Desc = Description.Text };
            _connection.InsertAsync(test);
            _test.Add(test);

        }
        void OnDelete(object sender, System.EventArgs e)
        {
            var del = _test[0];
            _connection.DeleteAsync(del);
            _test.Remove(del);

        }

        void OnUpdate(object sender, System.EventArgs e)
        {
            var update = _test[0];
            update.Title += "Updated";
            _connection.UpdateAsync(update);
            OnAppearing();

        }
    }
}