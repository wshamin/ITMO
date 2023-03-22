package Task09.Subtask01;

import java.util.Collection;
import java.util.HashSet;
import java.util.Set;

public class RemoveDuplicatesUtil {
    public static <T> Collection<T> removeDuplicates(Collection<T> collection) {
        Set<T> set = new HashSet<>(collection);
        return set;
    }
}
