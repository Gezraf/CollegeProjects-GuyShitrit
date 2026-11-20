public class AllEmployees {
    private Employee[] arr = new Employee[200];
    private int current = 0;

    public int numSupervisor() {
        int count = 0;
        for (int i = 0; i < current; i++) {
            if (arr[i] instanceof Supervisor)
                count++;
        }
        return count;
    }

    public Nurse getNewNurse(String type) {
        Nurse res = null;
        for (int i = 0; i < current; i++) {
            if (arr[i] instanceof Nurse) {
                Nurse n = (Nurse) arr[i];
                if (n.getType().equals(type) && (res == null || n.getNum() > res.getNum()))
                    res = n;
            }
        }
        return res;
    }
}
