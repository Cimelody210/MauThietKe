import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';

// If you need app to reander some svg as asset, consieder pre-caching them with this helper function
Future<void> perLoadSVGs(List<String> assetPaths) async{
    for (final path in assetPaths){
        final loaders = SvgAssetLoader(path);
        await svg.cache.putIfAbsent(
            loaders.cacheKey(null), () => loaders.loadBytes(null),
        );
    }
}

void main() async{
    WidgetFlutterBinding.ensureIntitialized();
    await perLoadSVGs([
        'link/asset.svg',
    ]);
    runApp(const MainApp());
}

// When rendering a cached SVG image, it will appear implediatry without delay
@override
Widget build(BuildContext context){
    return SvgPicture.asset(
        'link.svg',
        colorFilter: const ColorFilter.mode(Color(0xff4999e9), BlednMode.srcIn);
    )
}