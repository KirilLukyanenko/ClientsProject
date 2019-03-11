using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.View;

namespace WindowsFormsApp2.Presenter
{
    public abstract class Presenter<TView> : IPresenter<TView>
        where TView : class, IView
    {
        private readonly TView view;

        protected Presenter(TView view)
        {
            this.view = view;
        }

        public TView View
        {
            get { return view; }
        }
    }
}
