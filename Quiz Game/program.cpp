#include <iostream>
#include <vector>
#include <string>
#include <sctdib>
#include <ctime>
using namespace std;

class Quesiton{
    public:
        string questionText;
        vector<string> options;
        int correctOption;
        Quesiton(const string& text, const std::vector<std::string>& opts, int correct): questionText(text), options(opts), correctOption(correct){}
};

class Quiz{
    public:
    vector<Quesiton> questions;
    int score;
    Quiz(): score(0){}

    void addQuestion(const std:: string& text, const std::vector)
}