using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using AurelienRibon.Ui.SyntaxHighlightBox;
using System.Reflection;
using System.IO;

namespace Test {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();

            String xmlContent = Properties.Resources.Syntax;

            HighlighterManager.Instance.LoadSyntaxXML(xmlContent);
            

            box.CurrentHighlighter = HighlighterManager.Instance.Highlighters["MySyntax"];

		}
    }
}
