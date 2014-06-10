### IconLib

Mirror of http://www.codeproject.com/Articles/16178/IconLib-Icons-Unfolded-MultiIcon-and-Windows-Vista
upstream https://git.codeproject.com/castortiu/iconlib-icons-unfolded-multiicon-and-windows-vista

Can also be found at http://www.codeguru.com/csharp/.net/net_general/graphics/article.php/c12787/IconLib-Icons-Unfolded-MultiIcon-and-Windows-Vista-supported.htm

### Usage

    public void Convert(string pngPath, string icoPath)
    {
        MultiIcon mIcon = new MultiIcon();
        SingleIcon sIcon = mIcon.Add("Icon1");
        sIcon.CreateFrom(pngPath, IconOutputFormat.FromWin95);
        mIcon.SelectedIndex = 0;
        mIcon.Save(icoPath, MultiIconFormat.ICO);
    }

CreateFrom is a method exposed on SingleIcon class, this method will take a input image that must be 256x256 pixels and it must be a 32bpp (alpha channel must be included), the perfect candidate for this method are PNG24 images created for PhotoShop or any Image editing software.

The first parameter can be either the path to the png, or a `Bitmap` object. The second parameter in the API is a flag enumeration that target the OS which we want to create the icon, in the previous example it will take the input image and it will create the following IconImage formats.

256x256x32bpp (PNG compression)
48x48x32bpp 
48x48x8bpp
48x48x4bpp
32x32x32bpp
32x32x8bpp
16x16x32bpp
16x16x8bpp

### History

### IconLib 0.73 (01/31/2008)

Fixed a small problem with indexed 8bpp images.
Properly processing when adding PNG24 images.
Automatic Icon creation from a PNG or BMP32 for Vista, XP, W95 and Win31.
Added a new namespace "ColorProcessing" which supports
Color Reduction
Dithering
Palette Optimization
Allow to save an IconImage as PNG or BMP32 with transparency.
SingleIcon.Add() methods now returns a reference the IconImage just been created.
Some code and method signatures changes but backward compatible.
Demo application allows to export XOR, AND and Transparent Image, also now IconImages can be exported as PNG24 or BMP32.

### IconLib 0.72 (11/02/2006)

Change default shift factor from 9 to 10 for ICL libraries. (now it supports 64MB Max ICL file size).
Re-coded function to make vertical flip over Black&White images using pointers and memcopy (increased performance).
Different Namespaces for Bitmap Encoders and Library Formats.
Removed Static classes for Library Formats and replaced for a Interface from which the different formats implement.
Included IconLib license type.

### IconLib 0.71 (Initial Release)