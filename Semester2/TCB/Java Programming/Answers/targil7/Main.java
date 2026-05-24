public class Main {
    public static void main(String[] args) {
        Word w1 = new Word("בלון", "balloon");
        Word w2 = new Word("פארק", "park");
        Word w3 = new Word("מלפפון", "cucumber");
        Word w4 = new Word("אמיתי", "real");
        Word w5 = new Word("שחקן", "player");
        Word w6 = new Word("תוכנה", "program");

        Dictionary dict = new Dictionary();
        dict.addWord(w1);
        dict.addWord(w2);
        dict.addWord(w3);
        dict.addWord(w4);
        dict.addWord(w5);
        dict.addWord(w6);

        System.out.println(dict.translateFromHebrew("מלפפון"));
        System.out.println(dict.translateFromEnglish("real"));
        System.out.println(dict.showDictionary());
    }
}