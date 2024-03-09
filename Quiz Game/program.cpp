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

    void addQuestion(const std:: string& text, const std::vector<string>& opts, int correct){
        questions.emplace_back(text,opts, correct);
    }
}
void display(int index) const{
    const Quesiton& q = questions[index];
    cout << "Question" << index+1<<":"; << q.questions <<"\n";
    for (size_t i=0, i<q.options.size();, ++i){
        cout << " " << i+1<<":"; << q.options[i] <<"\n";
    }
}
void Start(){
    score  =0;
    for( size_t i=0, i < questions.size(); ++i){
        display(i);
        int userChoice = getUserChoice();
        if (userChoice== questions[i].correctOption){
            cout << "Exactly\n";
            score++;
        }
        else{
            cout << "Incorrect! Correct option is: " << questions[i].correctOption << "\n";
        }
    }
    cout << "Quiz completed! Your score is" << score << "/" << questions.size() << "\n";
    
}
int getUserChoice(){
    int choice;
    cout << "" << score << "/" << questions.size() << "\n";
    
}