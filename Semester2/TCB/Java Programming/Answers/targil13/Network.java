public class Network {
    private College[] colleges;

    public Network() {
        this.colleges = new College[80];
    }

    public void printMatchingYeshuv(String targetYeshuv) {
        boolean found = false;

        for (int i = 0; i < colleges.length; i++) {
            if (colleges[i].getYeshuv().equals(targetYeshuv)) {
                System.out.println(colleges[i].getName());

                if(!found)
                    found = true;
            }
        }

        if (!found) {
            System.out.println("No colleges found matching with yeshuv name");
        }
    }


    public String[] getAvailableColleges(int code) {
        String[] temp = new String[colleges.length]; // גודל מקסימלי לכסות על כל המכללות הקיימות
        int idx = 0;


        for (int i = 0; i < colleges.length; i++) {
            Major[] currMajors = colleges[i].getMajors();
            for (int j = 0; j < currMajors.length; j++) {
                if(currMajors[j].getCode() == code) {
                    temp[idx++] = colleges[i].getName();
                    break;
                }
            }
        }

        if (idx == 0)
            return null;

        String[] collegeNames = new String[idx]; // מערך סופי עם הגודל המדויק

        for (int i = 0; i < idx; i++) { // העתקה של המערך הזמני עם הגודל המקסימלי לתוך מערך סופי עם גודל מדויק
            collegeNames[i] = temp[i];
        }

        return collegeNames;
    }
}
