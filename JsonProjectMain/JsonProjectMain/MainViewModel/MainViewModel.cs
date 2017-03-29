using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;

namespace JsonProjectMain.MainViewModel
{
    public partial class MainViewModel_
    {

        public async void Save()
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add(".json", new List<string>() { ".json" });
            savePicker.DefaultFileExtension = ".json";
            savePicker.SuggestedFileName = "New Document";
            StorageFile file = await savePicker.PickSaveFileAsync();
        }

        public void AddToList(string box0, string box1, string box2, string box3, string box4, string box5, string box6, string box7, string box8, string box9)
        {
            string[] box { box0,box1,box2,b}
            for (int i = 0; i == 10; i++)
            {

            }
        }
        private bool valid()
        {
            bool status = true;

            return status;
        }
    }
}

