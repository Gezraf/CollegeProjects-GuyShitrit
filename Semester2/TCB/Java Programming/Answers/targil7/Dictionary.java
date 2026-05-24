public class Dictionary {
    private Word[] words;
    private int currIndex;

    public Dictionary() {
        this.words = new Word[1000];
        this.currIndex = 0;
    }

    public String translateFromEnglish(String st) {
        for (int i = 0; i < this.currIndex; i++) {
            if (this.words[i].getEnglishWord().equals(st))
                return this.words[i].getHebrewWord();
        }
        return null;
    }

    public String translateFromHebrew(String st) {
        for (int i = 0; i < this.currIndex; i++) {
            if (this.words[i].getHebrewWord().equals(st))
                return this.words[i].getEnglishWord();
        }
        return null;
    }

    public void addWord(Word newWord) {
        if (this.currIndex < this.words.length)
            this.words[this.currIndex++] = new Word(newWord.getHebrewWord(), newWord.getEnglishWord());
    }


    public String showDictionary() {
        String res = "";
        for (int i = 0; i < this.currIndex; i++) {
            res += this.words[i].ToString();
            if (i != this.currIndex - 1)
                res += "\n";
        }

        return res;
    }
}
