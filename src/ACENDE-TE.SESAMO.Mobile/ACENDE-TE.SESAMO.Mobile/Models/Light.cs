using ACENDE_TE.SESAMO.Shared.Entities;
using Newtonsoft.Json;
using Prism.Mvvm;
using System;

namespace ACENDE_TE.SESAMO.Mobile.Models
{
    public class Light : BindableBase, ILight
	{
        private Guid _guid;

		[JsonProperty("LedGuid")]
        public Guid Guid
        {
            get { return _guid; }
            set { SetProperty(ref _guid, value); }
        }
        
        private string _name;

		[JsonProperty("Name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _pin;

		[JsonProperty("Pin")]
        public int Pin
        {
            get { return _pin; }
            set { SetProperty(ref _pin, value); }
        }

         private bool _isOn;

		[JsonProperty("IsOn")]
        public bool IsOn
        {
            get { return _isOn; }
            set { SetProperty(ref _isOn, value); }
        }

        private int _action;

		[JsonProperty("action")]
        public int Action
        {
            get { return _action; }
            set { SetProperty(ref _action, value); }
        }
	}
}
