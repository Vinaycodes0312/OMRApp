using System.Collections.ObjectModel;
using OMRApp.Models;  //  Fix: Added missing namespace

namespace OMRApp.ViewModels;

public class OMRViewModel
{
    public ObservableCollection<QuestionModel> Questions { get; set; }

    public OMRViewModel()
    {
        Questions = new ObservableCollection<QuestionModel>
        {

        };
    }
}
