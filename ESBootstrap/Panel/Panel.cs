﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;



namespace ESBootstrap
{
	public class Panel : WidgetStyle
	{		
		public Panel(BootTheme type = BootTheme.Default, params Union<string, Widget, HTMLElement>[] typos) : base("panel" + Extensions.GetClassTheme(" panel-", type), typos)
		{			
								
		}
	}
}
