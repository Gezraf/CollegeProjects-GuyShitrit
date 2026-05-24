public class Word {
    private String hebrewWord;
    private String englishWord;

    public Word(String hebWord, String engWord) {
        this.hebrewWord = hebWord;
        this.englishWord = engWord;
    }

    public Word(Word other) {
        this.hebrewWord = other.hebrewWord;
        this.englishWord = other.englishWord;
    }

    public String getEnglishWord() {
        return englishWord;
    }

    public String getHebrewWord() {
        return hebrewWord;
    }

    public String ToString() {
        return this.getEnglishWord() + " = " + this.getHebrewWord();
    }

}
