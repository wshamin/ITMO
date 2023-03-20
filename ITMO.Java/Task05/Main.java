package Task05;

public class Main {
    public static void main(String[] args) {
        // Тестируем решение первого задания
        String text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry";
        String longestWord = StringEditor.findLongest(text);
        System.out.println(longestWord);
        System.out.println("----------");

        // Тестируем решение второго задания
        String palindrome = "Ротатор";
        String nonPalindrome = "Газель";
        System.out.println(StringEditor.isPalindrome(palindrome));
        System.out.println(StringEditor.isPalindrome(nonPalindrome));
        System.out.println("----------");

        // Тестируем решение третьего задания
        String word = "бякамобиль едет в бяка город по бяказаданию";
        System.out.println(StringEditor.replaceByaka(word));
        System.out.println("----------");

        // Тестируем решение четвертого задания
        String mainString1 = "Lorem Ipsum is simply Lorem Ipsum is simply " +
                "dummy text of the printing and Lorem Ipsum is simply typesetting industry";
        System.out.println(StringEditor.countSubstring(mainString1, "Lorem Ipsum"));
        System.out.println(StringEditor.countSubstring(mainString1, "text of the printing"));
        System.out.println(StringEditor.countSubstring(mainString1, "I have an apple"));
        String mainString2 = "кукукулалададакуку";
        System.out.println(StringEditor.countSubstring(mainString2, "ку"));
        System.out.println(StringEditor.countSubstring(mainString2, "лала"));
        System.out.println(StringEditor.countSubstring(mainString2, "даку"));
        System.out.println("----------");

        // Тестируем решение пятого задания
        System.out.println(StringEditor.invertWords("This is a test string"));
    }
}
