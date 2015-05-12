﻿//----------------------------------------------------------------------- 
// <copyright file="EncodingAMEPreset.cs" company="Microsoft">Copyright (c) Microsoft Corporation. All rights reserved.</copyright> 
// <license>
// Azure Media Services Explorer Ver. 3.2
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
//  
// http://www.apache.org/licenses/LICENSE-2.0 
//  
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License. 
// </license> 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAzure.MediaServices.Client;


namespace AMSExplorer
{
    public partial class EncodingAMEPreset : Form
    {
        private List<IMediaProcessor> Procs;
        private CloudMediaContext _context;

        public List<IMediaProcessor> EncodingProcessorsList
        {
            set
            {
                foreach (IMediaProcessor pr in value)
                    comboBoxProcessor.Items.Add(string.Format("{0} {1} Version {2} ({3})", pr.Vendor, pr.Name, pr.Version, pr.Description));
                comboBoxProcessor.SelectedIndex = 0;
                Procs = value;
            }
        }

        public JobOptionsVar JobOptions
        {
            get
            {
                return buttonJobOptions.GetSettings();
            }
            set
            {
                buttonJobOptions.SetSettings(value);
            }
        }

        public IMediaProcessor EncodingProcessorSelected
        {
            get
            {
                return Procs[comboBoxProcessor.SelectedIndex];
            }
        }

        public string EncodingJobName
        {
            get
            {
                return textBoxJobName.Text;
            }
            set
            {
                textBoxJobName.Text = value;
            }
        }



        public string EncodingLabel1
        {
            set
            {
                label.Text = value;
            }
        }

        public string EncodingLabel2
        {
            set
            {
                label2.Text = value;
            }
        }



        public string EncodingOutputAssetName
        {
            get
            {
                return outputassetname.Text;
            }
            set
            {
                outputassetname.Text = value;
            }
        }


        public List<string> EncodingSelectedPreset
        {
            get
            {
                List<string> ListOfPresets = new List<string>();
                foreach (var item in listbox.SelectedItems)
                    ListOfPresets.Add(item.ToString());

                return ListOfPresets;
            }
        }


        public EncodingAMEPreset(CloudMediaContext context)
        {
            InitializeComponent();
            this.Icon = Bitmaps.Azure_Explorer_ico;
            _context = context;
            buttonJobOptions.Initialize(_context);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void moreinfoprofilelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Send the URL to the operating system.
            Process.Start(e.Link.LinkData as string);
        }



        private void EncodingPreset_Load(object sender, EventArgs e)
        {
            moreinfoame.Links.Add(new LinkLabel.Link(0, moreinfoame.Text.Length, Constants.LinkMoreInfoAME));
            moreinfopresetslink.Links.Add(new LinkLabel.Link(0, moreinfopresetslink.Text.Length, Constants.LinkMorePresetsAME));

            // Populate the combo box with 
            // encoder task presets.
            listbox.Items.AddRange(
                typeof(MediaEncoderTaskPresetStrings)
                .GetFields()
                .Select(i => i.GetValue(null) as string)
                .ToArray()
                );

            listbox.SelectedItem = listbox.Items.Cast<string>()
                .SingleOrDefault(i => i == MediaEncoderTaskPresetStrings.H264AdaptiveBitrateMP4Set720p);

        }

        private void moreinfoame_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);

        }
    }
}
