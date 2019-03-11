using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2.Presenter
{
    public interface IPresenter<TView> where TView : class, IView
    {
        TView View { get; }
    }
}
