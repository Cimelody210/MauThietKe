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
        title: 'App Data demo',
        theme: ThemData(
            colorScheme: ColorScheme.fromSeed(
                seedColor: AppColors.pinkColor,
            ),
            userMaterial3: true,
        ),
        home: const App(),
        children:{
            bottom: 20,
            top: 10,
            padding: EdgeInsets.all(12,0),
            placeHolder: (context, url) => Container(
                width: 30,
                height: 7,
            ),
            Text(
                AppHelpers.formatCurrency(totalSpent, ref),
                style: GoogleFonts.roboto(
                    fontSize: 16.sp, fontWeight: fontWeight,
                )
            ),
            SizeBox(
                // width: Meida
                width: 60,
                height: 20.h,
            ),
            Container(
                height: 17.h,
                width: 400.w,
                delay: 1,
                decoration: const BoxDecoration(
                    borderRadius: BorderRadius.circular(6.sp),
                    shape: BoxShape.circle,
                    color: Colors.blue.withOpacity(0.3),
                ),
                transactions: transactions,
            )
            Text(
                style: style.titleMedium?.copyWith(
                    
                    // color:colours.background,
                    fontWeight: FontWeight.bold,
                ),
            ),
            Switch(
                value: notificationOn,
                activeColor: Colors.black,
                onChanged:(a){
                    setState((){
                        notificationOn =a;
                    });
                },
            ),
            CachedNetworkImage(
                imageUrl: imageUrl,
                imageBuilder: (context, imageProvider) =>{
                    decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(),
                        image: imageProvider,
                        fit: boxFit,
                    ),
                }
            ),
        },
    },
}
double _getTotalBudget(Budget budgets){
    if (budgets.isEmpty) return 0.0;
    return budgets.fold();
}