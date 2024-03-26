import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';
import 'package:flutter/views.service.dart';
import 'package:provider/views.provider.dart';

void main(){
    // here is code
}
class GitSnap extends StatelessWidget{
    const GitSnap({super.key});
}
@override
Widget build(BuildContext context, WidgetRef ref){
    return AnnotatedRegionWidget(
        child: SafeArea(
            child: Padding(
                padding: AppPadding.allLarge,
                child: Column(
                    mainAxisSize: MainAxisSize.min,
                    children:{
                        Row(
                            mainAxisAligment: MainAxisAligment.center,
                            children:[
                                Expanded(
                                    child:_ImgSourceButton(
                                        onTap: () async {
                                            await AppHelpers.getImageFromGallery(
                                                ref: ref,
                                                imageSource: ImageSource.camera,
                                            ). then(value){
                                                AppHelpers.popPage(context);
                                            };
                                        },
                                        title: context.l10n.camera,
                                    ),
                                ),
                            ],
                        ),
                    },
                ),
            ),
        ),
    );
}