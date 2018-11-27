package md51558244f76c53b6aeda52c8a337f2c37;


public class WebViewRenderer_WebClient
	extends android.webkit.WebViewClient
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPageFinished:(Landroid/webkit/WebView;Ljava/lang/String;)V:GetOnPageFinished_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"n_onReceivedError:(Landroid/webkit/WebView;ILjava/lang/String;Ljava/lang/String;)V:GetOnReceivedError_Landroid_webkit_WebView_ILjava_lang_String_Ljava_lang_String_Handler\n" +
			"n_onReceivedError:(Landroid/webkit/WebView;Landroid/webkit/WebResourceRequest;Landroid/webkit/WebResourceError;)V:GetOnReceivedError_Landroid_webkit_WebView_Landroid_webkit_WebResourceRequest_Landroid_webkit_WebResourceError_Handler\n" +
			"n_shouldOverrideUrlLoading:(Landroid/webkit/WebView;Ljava/lang/String;)Z:GetShouldOverrideUrlLoading_Landroid_webkit_WebView_Ljava_lang_String_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.WebViewRenderer+WebClient, Xamarin.Forms.Platform.Android", WebViewRenderer_WebClient.class, __md_methods);
	}


	public WebViewRenderer_WebClient ()
	{
		super ();
		if (getClass () == WebViewRenderer_WebClient.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.WebViewRenderer+WebClient, Xamarin.Forms.Platform.Android", "", this, new java.lang.Object[] {  });
	}

	public WebViewRenderer_WebClient (md51558244f76c53b6aeda52c8a337f2c37.WebViewRenderer p0)
	{
		super ();
		if (getClass () == WebViewRenderer_WebClient.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.WebViewRenderer+WebClient, Xamarin.Forms.Platform.Android", "Xamarin.Forms.Platform.Android.WebViewRenderer, Xamarin.Forms.Platform.Android", this, new java.lang.Object[] { p0 });
	}


	public void onPageFinished (android.webkit.WebView p0, java.lang.String p1)
	{
		n_onPageFinished (p0, p1);
	}

	private native void n_onPageFinished (android.webkit.WebView p0, java.lang.String p1);


	public void onReceivedError (android.webkit.WebView p0, int p1, java.lang.String p2, java.lang.String p3)
	{
		n_onReceivedError (p0, p1, p2, p3);
	}

	private native void n_onReceivedError (android.webkit.WebView p0, int p1, java.lang.String p2, java.lang.String p3);


	public void onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2)
	{
		n_onReceivedError (p0, p1, p2);
	}

	private native void n_onReceivedError (android.webkit.WebView p0, android.webkit.WebResourceRequest p1, android.webkit.WebResourceError p2);


	public boolean shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1)
	{
		return n_shouldOverrideUrlLoading (p0, p1);
	}

	private native boolean n_shouldOverrideUrlLoading (android.webkit.WebView p0, java.lang.String p1);

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
