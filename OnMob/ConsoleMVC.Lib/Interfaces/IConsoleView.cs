using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace OnMod.Proj.ConsoleMVC.Lib.Interfaces
{

    public interface IConsoleView 
    {
    	string ViewName {get;}
    	void Render();
    	
    }
}