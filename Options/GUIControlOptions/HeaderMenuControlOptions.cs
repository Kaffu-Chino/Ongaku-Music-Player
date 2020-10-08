using CSCore.Codecs;
using Microsoft.Win32;
using Ongaku.Model.Player;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace Ongaku.Options.HeaderMenuControlOptions
{
    class HeaderMenuControl
    {
        public OpenFileDialog GetFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Filter = CodecFactory.SupportedFilesFilterEn,
                Title = Application.Current.Resources["SelectedFiles"].ToString(),
                Multiselect = true
            };
            if(openFileDialog.ShowDialog() == true)
            {
                return openFileDialog;
            }
            return null;
        }

    }
}