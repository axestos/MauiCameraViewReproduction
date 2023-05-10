package crc64edac1bdb26069a72;


public class BarcodeAnalyzer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		androidx.camera.core.ImageAnalysis.Analyzer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_analyze:(Landroidx/camera/core/ImageProxy;)V:GetAnalyze_Landroidx_camera_core_ImageProxy_Handler:AndroidX.Camera.Core.ImageAnalysis/IAnalyzerInvoker, Xamarin.AndroidX.Camera.Core\n" +
			"";
		mono.android.Runtime.register ("BarcodeScanner.Mobile.Platforms.Android.BarcodeAnalyzer, BarcodeScanner.Mobile.Maui", BarcodeAnalyzer.class, __md_methods);
	}


	public BarcodeAnalyzer ()
	{
		super ();
		if (getClass () == BarcodeAnalyzer.class) {
			mono.android.TypeManager.Activate ("BarcodeScanner.Mobile.Platforms.Android.BarcodeAnalyzer, BarcodeScanner.Mobile.Maui", "", this, new java.lang.Object[] {  });
		}
	}


	public void analyze (androidx.camera.core.ImageProxy p0)
	{
		n_analyze (p0);
	}

	private native void n_analyze (androidx.camera.core.ImageProxy p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
