package util;

public class Format {
	
	public String formatUnicode(String unicode) {
		
		return unicode.replace("u00aa", "�")
				.replace("u00c1", "�")
				.replace("u00c3", "�")
				.replace("u00c9", "�")
				.replace("u00ca", "�")
				.replace("u00cd", "�")
				.replace("u00d5", "�")
				.replace("u00d3", "�")
				.replace("u00d4", "�")
				.replace("u00da", "�")
				.replace("u00c7", "�");
	}
}
