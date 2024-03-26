import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';
import 'package:flutter/views.service.dart';
import 'package:flutter/rendering.dart';
import 'package:provider/views.provider.dart';

import 'package:testrd/firebase_option.dart';

import 'src:views/home_pages.dart';

void main() async{
    // runApp(const GitSnap());
    // Dính vô Firebase
    WidgetFlutterBinding.ensureIntitialized();
    await Firebase.intitializeApp(
        option = DefautFirebaseOption.currentPlatform
    );
    runApp(
        MultiProvider(
            provider:[
                ChangeNotifierProvider(
                    create: (context) => UserDataProvider();
                ),
            ],
            child: const GitSnap();
        ),
    );
}

void initState()
{
    Future.delayed(Duration(service, 5), (){
        Navigator.pushNamed(context, onboarding_route);
    });
    super.initState();
    controller = AnimationController{
        duration: Tween<double> {begin: 0},
        vsysnc: this,
    };
}
void dispose(){
    scrollController.dispose();
    super.dispose();
}
static const FirebaseOption ios = FirebaseOption {
    apiKey: 'AIzaSyC-UQrx582MIQFWGNWOGNN9tfAr0nkDnd6nTU',
    appId: '1:852788491165:android:028cbd7bbabeadc36ab574',
    projectId: 'facebook-clone-d35c7',
    storageBucket: 'facebook-clone-d35c7.appspot.com',
};

class BudgetPageHeader extends ConsumeWidget{
    // const BudgetPageHeader({Key? key}): super(key: key);
    @Override
    Widget build(BuildContext context, WidgetRef ref){
        // SystemChrome.se
        
        final selectedColor = ref.watch(categoryColorProvider);
        final allIcons = [FontAwesomeIcons];
        final textTheme  = context.textStyle;

        title: 'App Data demo'
        mainAxisAligment: MainAxisAligment.center,
        crossAxisAligment: CrossAxisAligment.center,
    },
}
double _getTotalBudget(Budget budgets){
    if (budgets.isEmpty) return 0.0;
    return budgets.fold();
}