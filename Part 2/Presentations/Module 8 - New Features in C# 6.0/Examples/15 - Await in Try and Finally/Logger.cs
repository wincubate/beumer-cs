using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module08.Slide15
{
	public class Logger
	{
		private string _file;

		public Logger( string file )
		{
			_file = file;
		}

		public Task LogAsync( string s )
		{
			File.AppendAllText(_file, s );
			return Task.CompletedTask;
		}

		public Task LogExceptionAsync(Exception e)
		{
			File.AppendAllText(_file, e.Message);
			return Task.CompletedTask;
		}
	}
}
