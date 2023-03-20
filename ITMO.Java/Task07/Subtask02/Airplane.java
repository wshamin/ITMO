package Task07.Subtask02;

public class Airplane {
    Wing wing = new Wing();

    class Wing {
        private int weight;

        public void setWeight(int weight) {
            this.weight = weight;
        }

        public int getWeight() {
            return weight;
        }
    }
}
