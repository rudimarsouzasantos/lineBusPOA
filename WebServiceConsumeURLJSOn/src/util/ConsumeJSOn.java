package util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class ConsumeJSOn {
	
	URL obj;
	HttpURLConnection con;
	BufferedReader in;
	String inputLine;
	StringBuffer response;
	Format format = new Format();
	public ConsumeJSOn() {}
	
	public String connectionURL(String url) throws IOException {
		try {
			obj = new URL(url);
		    con = (HttpURLConnection) obj.openConnection();
		    con.setRequestMethod("GET");		
		    in = new BufferedReader(new InputStreamReader(con.getInputStream()));
		    response = new StringBuffer();
		    
		    while ((inputLine = in.readLine()) != null) {
		    	response.append(inputLine);
		     }
		} catch (Exception msgURLError) {
			return msgURLError.toString();
		}
	     in.close();
	     return format.formatUnicode(response.toString());
	} 
}
