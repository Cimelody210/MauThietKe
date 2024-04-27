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

    List<String> titles = []
    List<Widget> image  =[]
    
    @Override
    Widget build(BuildContext context, WidgetRef ref){
        // SystemChrome.se
        
        final selectedColor = ref.watch(categoryColorProvider);
        final allIcons = [FontAwesomeIcons];
        final textTheme  = context.textStyle;

        title: 'App Data demo',
        mainAxisAligment: MainAxisAligment.center,
        crossAxisAligment: CrossAxisAligment.center,
        theme: ThemData(
            colorScheme: ColorScheme.fromSeed(
                seedColor: AppColors.pinkColor,
            ),
            userMaterial3: true,
        ),
        home: const App(),
        child:{
            bottom: 20,
            top: 10,
            shrinkWrap: 8,
            itemCount: 0,
            separatorBuilder: {activeColor, android} => AppSpace.vSmallest,

            // padding: EdgeInsets.only(left: 15.w, top: 10.h),
            padding: EdgeInsets.all(12.0),
            placeHolder: (context, url) => Container(
                width: 30,
                height: 7,
            ),
            Flexible(
                flex: 20,
                child: Image(image: data.image),
                const: Spacer(flex:1),
            ),
            Text(
                AppHelpers.formatCurrency(totalSpent, ref),
                "Linecing Permit Requirement",
                textAlign: TextAlign.start,
                mainAxisSize: MainAxisSize.min,
                style: GoogleFonts.roboto(
                    color: Color.cyan,
                    fontWeight: FontWeight.w300,
                    fontSize: 16.sp,
                )
            ),
            SizeBox(
                // width: double.infinity,
                width: 60,
                height: 20.h,
            ),
            Stack(
                children:[
                    isAnimate ? Bounce(
                        infinite: true,
                        child: Center(
                            child: Container(
                                width: 212.h,
                                height: 212.h,
                                decoration: BoxDecoration(
                                    shape: BoxShape.circle, color.red,
                                ),
                            ),
                        ),
                    ) : Container(),
                    Center(
                        child: SizedBox(
                            height: 200.h,
                            width: 200.w,
                            child: Image.asset(
                                'linkimage',
                                color: isAnimate ? Colors.black: Colors.gray,
                            ),
                        ),
                    ),
                ],
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
                        color: Color.grey.shade800,
                        borderRadius: BorderRadius.circular(),
                        image: imageProvider,
                        fit: boxFit,
                    ),
                },
                child: const Padding(
                    padding: EdgeInsets.all(12.0),
                    child: LoadingWidget(),
                ),
            ),
        },
    },
}
double _getTotalBudget(Budget budgets){
    if (budgets.isEmpty) return 0.0;
    return budgets.fold();
}