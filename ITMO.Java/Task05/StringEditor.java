package Task05;

public class StringEditor {
    public static String findLongest(String text) {
        String[] textWords = text.split(" ");
        String longestWord = "";
        for (String word : textWords) {
            if (word.length() > longestWord.length()) {
                longestWord = word;
            }
        }
        return longestWord;
    }

    public static boolean isPalindrome(String word) {
        StringBuilder stringBuilderReverseWord = new StringBuilder(word);
        stringBuilderReverseWord.reverse();
        String reverseWord = stringBuilderReverseWord.toString();
        return word.equalsIgnoreCase(reverseWord);
    }

    public static String replaceByaka(String word) {
        String byakaWord = word.replaceAll("бяка", "[вырезано цензурой]");
        return byakaWord;
    }

    public static int countSubstring(String mainstring, String substring) {
        int count = 0;

        if (substring.length() > mainstring.length()) {
            return count;
        }

        for (int i = 0; i < mainstring.length(); i++) {
            if (mainstring.substring(i, substring.length() + i).equals(substring)) {
                count += 1;
            }

            if (i + substring.length() == mainstring.length()) {
                break;
            }
        }

        return count;
    }

    public static String invertWords(String str) {
        String[] strings = str.split(" ");
        StringBuilder resultStr = new StringBuilder();
        for (String s : strings) {
            StringBuilder sb = new StringBuilder(s);
            sb.reverse();
            resultStr.append(sb).append(" ");
        }
        return resultStr.toString();
    }
}
