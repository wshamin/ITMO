package Task10;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class FileEditor {
    public static List<String> readFile(String filePath) {
        List<String> lines = new ArrayList<>();
        try (BufferedReader reader = new BufferedReader(new FileReader(filePath))) {
            String line;
            while ((line = reader.readLine()) != null) {
                lines.add(line);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
        return lines;
    }

    public static void writeFile(String filePath, String content) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(filePath, true))) {
            writer.newLine();
            writer.write(content);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void concatenateFiles(String file1, String file2, String outputFile) {
        List<String> linesFile1 = readFile(file1);
        List<String> linesFile2 = readFile(file2);

        try (BufferedWriter writer = new BufferedWriter(new FileWriter(outputFile))) {
            for (String line : linesFile1) {
                writer.write(line);
                writer.newLine();
            }
            for (String line : linesFile2) {
                writer.write(line);
                writer.newLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void replaceNonAlphanumeric(String filePath) {
        List<String> lines = readFile(filePath);

        try (BufferedWriter writer = new BufferedWriter(new FileWriter(filePath))) {
            for (String line : lines) {
                String replaced = line.replaceAll("[^a-zA-Z0-9]", "\\$");
                writer.write(replaced);
                writer.newLine();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        // Тестируем первый метод
        List<String> strings = readFile("ITMO.Java/Task10/files/Strings1.txt");
        for (String s : strings) {
            System.out.println(s);
        }

        // Тестируем второй метод
        writeFile("ITMO.Java/Task10/files/Strings1.txt", "Hello world!");

        // Тестируем третий метод
        String file1 = "ITMO.Java/Task10/files/Strings1.txt";
        String file2 = "ITMO.Java/Task10/files/Strings2.txt";
        String outputFile = "ITMO.Java/Task10/files/output.txt";

        concatenateFiles(file1, file2, outputFile);

        // Тестируем четвертый метод
        replaceNonAlphanumeric(outputFile);
    }
}
