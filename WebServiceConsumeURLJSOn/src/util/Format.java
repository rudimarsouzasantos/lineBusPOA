package util;

public class Format {
	
	public String formatUnicode(String unicode) {
		
		return unicode.replace("u00aa", "ª")
				.replace("u00c1", "Á")
				.replace("u00c3", "Ã")
				.replace("u00c9", "É")
				.replace("u00ca", "Ê")
				.replace("u00cd", "Í")
				.replace("u00d5", "Õ")
				.replace("u00d3", "Ó")
				.replace("u00d4", "Ô")
				.replace("u00da", "Ú")
				.replace("u00c7", "Ç");
	}
}
