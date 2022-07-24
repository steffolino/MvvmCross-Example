using System.Threading.Tasks;
using Example.Core.Services;
using MvvmCross.ViewModels;

namespace Example.Core.ViewModels
{
    public class StartViewModel : MvxViewModel
    {
        private readonly INameService _nameService;
        private string _name;
        private string _firstName;

        public StartViewModel(INameService nameService)
        {
            _nameService = nameService;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (SetProperty(ref _name, value))
                    RaisePropertyChanged(nameof(Message));
            }
        }

        public string Firstname
        {
            get => _firstName;
            set
            {
                if (SetProperty(ref _firstName, value))
                    RaisePropertyChanged(nameof(Message));
            }
        }

        public string Message
        {
            get => _nameService.BuildMessage(Name, Firstname);
        }


        public override async Task Initialize()
        {
            await base.Initialize();

            RaisePropertyChanged(() => Message);
        }
    }
}