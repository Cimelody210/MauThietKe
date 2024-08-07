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
        final kichthuoc = MediaQuery.of(context).size;
        final difi = kichthuoc!= null ? selectedColor: 0.5;

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
        children:{
            bottom: 20,
            top: 10,
            shrinkWrap: 8,
            itemCount: 0,
            mainAxisAligment: MainAxisAligment.center,
            separatorBuilder: {activeColor, android} => AppSpace.vSmallest,

            // padding: EdgeInsets.only(left: 15.w, top: 10.h),
            padding: EdgeInsets.all(12.0),
            MouseRegion:(
                onHover: {event}{
                    setHoverEvent(event, kichthuoc);
                },
                onExit:(event){
                    setHoverCenterEvent(event, kichthuoc);
                },
            ),
            placeHolder: (context, url) => Container(
                width: 30,
                height: 7,
            ),
            Expanded(
                child: center,
                borderRadius: BorderRadius.circular(20),
                decoration: const BoxDecoration(
                    shape: BoxShape.circle,
                    image: DecorationImage(
                        image: AssetImage('asset/demo.png');
                    );
                ),
                style: TextStyle(
                    color: Color.gray,
                    fontSize:30,
                    fontWeight: FontWeight.bold;
                );
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
                    shape: const StadiumBorder(),
                )
            ),
            AnimatedOpacity(
                opacity: 0,
                duration: const Duration(
                    child: AlignmentAlign(
                        alignment: toggleState ? Alignment.centerLeft : Alignment.centerRight
                    ),
                ),
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
                            onTap: ()=> FocusScope.of(context).unfocus(),
                            child: Container(
                                key: _formKey,
                                padding:
                                    const EdgeInsets.all(Dimens.HORIZONTAL_PADDING *2),
                                width: 212.h,
                                height: 212.h,
                                decoration: BoxDecoration(
                                    shape: BoxShape.circle, color.red,
                                ),
                                LoginHeader(
                                    text: translate('authgbg'),
                                )
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
                bottom: TabBar(
                  controller: _tabcontroller,
                  labelColor: Theme.of(context).primaryColor,
                  labelStyle: TextStyle(fontSize: 16.0, fontWeight: FontWeight.w600),
                  unselectedLabelStyle: TextStyle(fontSize:16.0),
                  tabs:(
                    Tab(
                        text: "Trenf"
                    ),
                    Tab(
                        text: "Trenffhf fjhrb djhfhf"
                    ),
                  ) , 
                ),
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
