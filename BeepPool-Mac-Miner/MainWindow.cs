using System;
using Foundation;
using AppKit;

namespace BeepPool_Mac_Miner
{
	public partial class MainWindow : NSWindow
	{
		#region Constructors

		// Called when created from unmanaged code
		public MainWindow(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public MainWindow(NSCoder coder) : base(coder)
		{
			Initialize();
		}

		// Shared initialization code
		void Initialize()
		{
		}

		#endregion
	}
}