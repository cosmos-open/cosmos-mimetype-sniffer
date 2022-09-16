﻿using System.Collections.Generic;
using Cosmos.Sniffers.MimeTypeSniffers.Core;

namespace Cosmos.Sniffers.MimeTypeSniffers.Providers;

/// <summary>
/// Default Mime Type Provider <br />
/// 默认的 MIME 类型提供者程序
/// </summary>
public class DefaultMimeTypeProvider : IMimeTypeProvider
{
    private readonly Dictionary<string, string> _mimeTypes;

    public DefaultMimeTypeProvider()
    {
        _mimeTypes = new Dictionary<string, string>();
        Initialize();
    }

    private void Initialize()
    {
        _mimeTypes.Add("323", "text/h323");
        _mimeTypes.Add("3dmf", "x-world/x-3dmf");
        _mimeTypes.Add("3dm", "x-world/x-3dmf");
        _mimeTypes.Add("3g2", "video/3gpp2");
        _mimeTypes.Add("3gp", "video/3gpp");
        _mimeTypes.Add("7z", "application/x-7z-compressed");
        _mimeTypes.Add("aab", "application/x-authorware-bin");
        _mimeTypes.Add("aac", "audio/aac");
        _mimeTypes.Add("aam", "application/x-authorware-map");
        _mimeTypes.Add("aas", "application/x-authorware-seg");
        _mimeTypes.Add("abc", "text/vnd.abc");
        _mimeTypes.Add("acgi", "text/html");
        _mimeTypes.Add("acx", "application/internet-property-stream");
        _mimeTypes.Add("afl", "video/animaflex");
        _mimeTypes.Add("ai", "application/postscript");
        _mimeTypes.Add("aif", "audio/aiff");
        _mimeTypes.Add("aifc", "audio/aiff");
        _mimeTypes.Add("aiff", "audio/aiff");
        _mimeTypes.Add("aim", "application/x-aim");
        _mimeTypes.Add("aip", "text/x-audiosoft-intra");
        _mimeTypes.Add("ani", "application/x-navi-animation");
        _mimeTypes.Add("aos", "application/x-nokia-9000-communicator-add-on-software");
        _mimeTypes.Add("appcache", "text/cache-manifest");
        _mimeTypes.Add("application", "application/x-ms-application");
        _mimeTypes.Add("aps", "application/mime");
        _mimeTypes.Add("art", "image/x-jg");
        _mimeTypes.Add("asf", "video/x-ms-asf");
        _mimeTypes.Add("asm", "text/x-asm");
        _mimeTypes.Add("asp", "text/asp");
        _mimeTypes.Add("asr", "video/x-ms-asf");
        _mimeTypes.Add("asx", "application/x-mplayer2");
        _mimeTypes.Add("atom", "application/atom+xml");
        _mimeTypes.Add("au", "audio/x-au");
        _mimeTypes.Add("avi", "video/avi");
        _mimeTypes.Add("avs", "video/avs-video");
        _mimeTypes.Add("axs", "application/olescript");
        _mimeTypes.Add("bas", "text/plain");
        _mimeTypes.Add("bcpio", "application/x-bcpio");
        _mimeTypes.Add("bin", "application/octet-stream");
        _mimeTypes.Add("bm", "image/bmp");
        _mimeTypes.Add("bmp", "image/bmp");
        _mimeTypes.Add("boo", "application/book");
        _mimeTypes.Add("book", "application/book");
        _mimeTypes.Add("boz", "application/x-bzip2");
        _mimeTypes.Add("bsh", "application/x-bsh");
        _mimeTypes.Add("bz2", "application/x-bzip2");
        _mimeTypes.Add("bz", "application/x-bzip");
        _mimeTypes.Add("cat", "application/vnd.ms-pki.seccat");
        _mimeTypes.Add("ccad", "application/clariscad");
        _mimeTypes.Add("cco", "application/x-cocoa");
        _mimeTypes.Add("cc", "text/plain");
        _mimeTypes.Add("cdf", "application/cdf");
        _mimeTypes.Add("cer", "application/pkix-cert");
        _mimeTypes.Add("cha", "application/x-chat");
        _mimeTypes.Add("chat", "application/x-chat");
        _mimeTypes.Add("class", "application/x-java-applet");
        _mimeTypes.Add("clp", "application/x-msclip");
        _mimeTypes.Add("cmx", "image/x-cmx");
        _mimeTypes.Add("cod", "image/cis-cod");
        _mimeTypes.Add("coffee", "text/x-coffeescript");
        _mimeTypes.Add("conf", "text/plain");
        _mimeTypes.Add("cpio", "application/x-cpio");
        _mimeTypes.Add("cpp", "text/plain");
        _mimeTypes.Add("cpt", "application/x-cpt");
        _mimeTypes.Add("crd", "application/x-mscardfile");
        _mimeTypes.Add("crl", "application/pkix-crl");
        _mimeTypes.Add("crt", "application/pkix-cert");
        _mimeTypes.Add("csh", "application/x-csh");
        _mimeTypes.Add("css", "text/css");
        _mimeTypes.Add("c", "text/plain");
        _mimeTypes.Add("c++", "text/plain");
        _mimeTypes.Add("cxx", "text/plain");
        _mimeTypes.Add("dart", "application/dart");
        _mimeTypes.Add("dcr", "application/x-director");
        _mimeTypes.Add("deb", "application/x-deb");
        _mimeTypes.Add("deepv", "application/x-deepv");
        _mimeTypes.Add("def", "text/plain");
        _mimeTypes.Add("deploy", "application/octet-stream");
        _mimeTypes.Add("der", "application/x-x509-ca-cert");
        _mimeTypes.Add("dib", "image/bmp");
        _mimeTypes.Add("dif", "video/x-dv");
        _mimeTypes.Add("dir", "application/x-director");
        _mimeTypes.Add("disco", "text/xml");
        _mimeTypes.Add("dll", "application/x-msdownload");
        _mimeTypes.Add("dl", "video/dl");
        _mimeTypes.Add("doc", "application/msword");
        _mimeTypes.Add("docm", "application/vnd.ms-word.document.macroEnabled.12");
        _mimeTypes.Add("docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        _mimeTypes.Add("dot", "application/msword");
        _mimeTypes.Add("dotm", "application/vnd.ms-word.template.macroEnabled.12");
        _mimeTypes.Add("dotx", "application/vnd.openxmlformats-officedocument.wordprocessingml.template");
        _mimeTypes.Add("dp", "application/commonground");
        _mimeTypes.Add("drw", "application/drafting");
        _mimeTypes.Add("dtd", "application/xml-dtd");
        _mimeTypes.Add("dvi", "application/x-dvi");
        _mimeTypes.Add("dv", "video/x-dv");
        _mimeTypes.Add("dwf", "drawing/x-dwf (old)");
        _mimeTypes.Add("dwg", "application/acad");
        _mimeTypes.Add("dxf", "application/dxf");
        _mimeTypes.Add("dxr", "application/x-director");
        _mimeTypes.Add("el", "text/x-script.elisp");
        _mimeTypes.Add("elc", "application/x-elc");
        _mimeTypes.Add("eml", "message/rfc822");
        _mimeTypes.Add("eot", "application/vnd.bw-fontobject");
        _mimeTypes.Add("eps", "application/postscript");
        _mimeTypes.Add("epub", "application/epub+zip");
        _mimeTypes.Add("es", "application/x-esrehber");
        _mimeTypes.Add("etx", "text/x-setext");
        _mimeTypes.Add("evy", "application/envoy");
        _mimeTypes.Add("exe", "application/octet-stream");
        _mimeTypes.Add("f77", "text/plain");
        _mimeTypes.Add("f90", "text/plain");
        _mimeTypes.Add("fdf", "application/vnd.fdf");
        _mimeTypes.Add("fif", "image/fif");
        _mimeTypes.Add("flac", "audio/x-flac");
        _mimeTypes.Add("fli", "video/fli");
        _mimeTypes.Add("flo", "image/florian");
        _mimeTypes.Add("flr", "x-world/x-vrml");
        _mimeTypes.Add("flx", "text/vnd.fmi.flexstor");
        _mimeTypes.Add("fmf", "video/x-atomic3d-feature");
        _mimeTypes.Add("for", "text/plain");
        _mimeTypes.Add("fpx", "image/vnd.fpx");
        _mimeTypes.Add("frl", "application/freeloader");
        _mimeTypes.Add("f", "text/plain");
        _mimeTypes.Add("funk", "audio/make");
        _mimeTypes.Add("g3", "image/g3fax");
        _mimeTypes.Add("gif", "image/gif");
        _mimeTypes.Add("gl", "video/gl");
        _mimeTypes.Add("gsd", "audio/x-gsm");
        _mimeTypes.Add("gsm", "audio/x-gsm");
        _mimeTypes.Add("gsp", "application/x-gsp");
        _mimeTypes.Add("gss", "application/x-gss");
        _mimeTypes.Add("gtar", "application/x-gtar");
        _mimeTypes.Add("g", "text/plain");
        _mimeTypes.Add("gz", "application/x-gzip");
        _mimeTypes.Add("gzip", "application/x-gzip");
        _mimeTypes.Add("hdf", "application/x-hdf");
        _mimeTypes.Add("help", "application/x-helpfile");
        _mimeTypes.Add("hgl", "application/vnd.hp-HPGL");
        _mimeTypes.Add("hh", "text/plain");
        _mimeTypes.Add("hlb", "text/x-script");
        _mimeTypes.Add("hlp", "application/x-helpfile");
        _mimeTypes.Add("hpg", "application/vnd.hp-HPGL");
        _mimeTypes.Add("hpgl", "application/vnd.hp-HPGL");
        _mimeTypes.Add("hqx", "application/binhex");
        _mimeTypes.Add("hta", "application/hta");
        _mimeTypes.Add("htc", "text/x-component");
        _mimeTypes.Add("h", "text/plain");
        _mimeTypes.Add("htmls", "text/html");
        _mimeTypes.Add("html", "text/html");
        _mimeTypes.Add("htm", "text/html");
        _mimeTypes.Add("htt", "text/webviewhtml");
        _mimeTypes.Add("htx", "text/html");
        _mimeTypes.Add("ice", "x-conference/x-cooltalk");
        _mimeTypes.Add("ico", "image/x-icon");
        _mimeTypes.Add("ics", "text/calendar");
        _mimeTypes.Add("idc", "text/plain");
        _mimeTypes.Add("ief", "image/ief");
        _mimeTypes.Add("iefs", "image/ief");
        _mimeTypes.Add("iges", "application/iges");
        _mimeTypes.Add("igs", "application/iges");
        _mimeTypes.Add("iii", "application/x-iphone");
        _mimeTypes.Add("ima", "application/x-ima");
        _mimeTypes.Add("imap", "application/x-httpd-imap");
        _mimeTypes.Add("inf", "application/inf");
        _mimeTypes.Add("ins", "application/x-internett-signup");
        _mimeTypes.Add("ip", "application/x-ip2");
        _mimeTypes.Add("isp", "application/x-internet-signup");
        _mimeTypes.Add("isu", "video/x-isvideo");
        _mimeTypes.Add("it", "audio/it");
        _mimeTypes.Add("iv", "application/x-inventor");
        _mimeTypes.Add("ivf", "video/x-ivf");
        _mimeTypes.Add("ivr", "i-world/i-vrml");
        _mimeTypes.Add("ivy", "application/x-livescreen");
        _mimeTypes.Add("jam", "audio/x-jam");
        _mimeTypes.Add("jar", "application/java-archive");
        _mimeTypes.Add("java", "text/plain");
        _mimeTypes.Add("jav", "text/plain");
        _mimeTypes.Add("jcm", "application/x-java-commerce");
        _mimeTypes.Add("jfif", "image/jpeg");
        _mimeTypes.Add("jfif-tbnl", "image/jpeg");
        _mimeTypes.Add("jpeg", "image/jpeg");
        _mimeTypes.Add("jpe", "image/jpeg");
        _mimeTypes.Add("jpg", "image/jpeg");
        _mimeTypes.Add("jps", "image/x-jps");
        _mimeTypes.Add("js", "application/javascript");
        _mimeTypes.Add("json", "application/json");
        _mimeTypes.Add("jut", "image/jutvision");
        _mimeTypes.Add("kar", "audio/midi");
        _mimeTypes.Add("ksh", "text/x-script.ksh");
        _mimeTypes.Add("la", "audio/nspaudio");
        _mimeTypes.Add("lam", "audio/x-liveaudio");
        _mimeTypes.Add("latex", "application/x-latex");
        _mimeTypes.Add("list", "text/plain");
        _mimeTypes.Add("lma", "audio/nspaudio");
        _mimeTypes.Add("log", "text/plain");
        _mimeTypes.Add("lsp", "application/x-lisp");
        _mimeTypes.Add("lst", "text/plain");
        _mimeTypes.Add("lsx", "text/x-la-asf");
        _mimeTypes.Add("ltx", "application/x-latex");
        _mimeTypes.Add("m13", "application/x-msmediaview");
        _mimeTypes.Add("m14", "application/x-msmediaview");
        _mimeTypes.Add("m1v", "video/mpeg");
        _mimeTypes.Add("m2a", "audio/mpeg");
        _mimeTypes.Add("m2v", "video/mpeg");
        _mimeTypes.Add("m3u", "audio/x-mpequrl");
        _mimeTypes.Add("m4a", "audio/mp4");
        _mimeTypes.Add("m4v", "video/mp4");
        _mimeTypes.Add("man", "application/x-troff-man");
        _mimeTypes.Add("manifest", "application/x-ms-manifest");
        _mimeTypes.Add("map", "application/x-navimap");
        _mimeTypes.Add("mar", "text/plain");
        _mimeTypes.Add("mbd", "application/mbedlet");
        _mimeTypes.Add("mc$", "application/x-magic-cap-package-1.0");
        _mimeTypes.Add("mcd", "application/mcad");
        _mimeTypes.Add("mcf", "image/vasa");
        _mimeTypes.Add("mcp", "application/netmc");
        _mimeTypes.Add("mdb", "application/x-msaccess");
        _mimeTypes.Add("mesh", "model/mesh");
        _mimeTypes.Add("me", "application/x-troff-me");
        _mimeTypes.Add("mid", "audio/midi");
        _mimeTypes.Add("midi", "audio/midi");
        _mimeTypes.Add("mif", "application/x-mif");
        _mimeTypes.Add("mjf", "audio/x-vnd.AudioExplosion.MjuiceMediaFile");
        _mimeTypes.Add("mjpg", "video/x-motion-jpeg");
        _mimeTypes.Add("mm", "application/base64");
        _mimeTypes.Add("mme", "application/base64");
        _mimeTypes.Add("mny", "application/x-msmoney");
        _mimeTypes.Add("mod", "audio/mod");
        _mimeTypes.Add("mov", "video/quicktime");
        _mimeTypes.Add("movie", "video/x-sgi-movie");
        _mimeTypes.Add("mp2", "video/mpeg");
        _mimeTypes.Add("mp3", "audio/mpeg");
        _mimeTypes.Add("mp4", "video/mp4");
        _mimeTypes.Add("mp4a", "audio/mp4");
        _mimeTypes.Add("mp4v", "video/mp4");
        _mimeTypes.Add("mpa", "audio/mpeg");
        _mimeTypes.Add("mpc", "application/x-project");
        _mimeTypes.Add("mpeg", "video/mpeg");
        _mimeTypes.Add("mpe", "video/mpeg");
        _mimeTypes.Add("mpga", "audio/mpeg");
        _mimeTypes.Add("mpg", "video/mpeg");
        _mimeTypes.Add("mpp", "application/vnd.ms-project");
        _mimeTypes.Add("mpt", "application/x-project");
        _mimeTypes.Add("mpv2", "video/mpeg");
        _mimeTypes.Add("mpv", "application/x-project");
        _mimeTypes.Add("mpx", "application/x-project");
        _mimeTypes.Add("mrc", "application/marc");
        _mimeTypes.Add("ms", "application/x-troff-ms");
        _mimeTypes.Add("msh", "model/mesh");
        _mimeTypes.Add("m", "text/plain");
        _mimeTypes.Add("mvb", "application/x-msmediaview");
        _mimeTypes.Add("mv", "video/x-sgi-movie");
        _mimeTypes.Add("my", "audio/make");
        _mimeTypes.Add("mzz", "application/x-vnd.AudioExplosion.mzz");
        _mimeTypes.Add("nap", "image/naplps");
        _mimeTypes.Add("naplps", "image/naplps");
        _mimeTypes.Add("nc", "application/x-netcdf");
        _mimeTypes.Add("ncm", "application/vnd.nokia.configuration-message");
        _mimeTypes.Add("niff", "image/x-niff");
        _mimeTypes.Add("nif", "image/x-niff");
        _mimeTypes.Add("nix", "application/x-mix-transfer");
        _mimeTypes.Add("nsc", "application/x-conference");
        _mimeTypes.Add("nvd", "application/x-navidoc");
        _mimeTypes.Add("nws", "message/rfc822");
        _mimeTypes.Add("oda", "application/oda");
        _mimeTypes.Add("ods", "application/oleobject");
        _mimeTypes.Add("oga", "audio/ogg");
        _mimeTypes.Add("ogg", "audio/ogg");
        _mimeTypes.Add("ogv", "video/ogg");
        _mimeTypes.Add("ogx", "application/ogg");
        _mimeTypes.Add("omc", "application/x-omc");
        _mimeTypes.Add("omcd", "application/x-omcdatamaker");
        _mimeTypes.Add("omcr", "application/x-omcregerator");
        _mimeTypes.Add("opus", "audio/ogg");
        _mimeTypes.Add("oxps", "application/oxps");
        _mimeTypes.Add("p10", "application/pkcs10");
        _mimeTypes.Add("p12", "application/pkcs-12");
        _mimeTypes.Add("p7a", "application/x-pkcs7-signature");
        _mimeTypes.Add("p7b", "application/x-pkcs7-certificates");
        _mimeTypes.Add("p7c", "application/pkcs7-mime");
        _mimeTypes.Add("p7m", "application/pkcs7-mime");
        _mimeTypes.Add("p7r", "application/x-pkcs7-certreqresp");
        _mimeTypes.Add("p7s", "application/pkcs7-signature");
        _mimeTypes.Add("part", "application/pro_eng");
        _mimeTypes.Add("pas", "text/pascal");
        _mimeTypes.Add("pbm", "image/x-portable-bitmap");
        _mimeTypes.Add("pcl", "application/x-pcl");
        _mimeTypes.Add("pct", "image/x-pict");
        _mimeTypes.Add("pcx", "image/x-pcx");
        _mimeTypes.Add("pdb", "chemical/x-pdb");
        _mimeTypes.Add("pdf", "application/pdf");
        _mimeTypes.Add("pfunk", "audio/make");
        _mimeTypes.Add("pfx", "application/x-pkcs12");
        _mimeTypes.Add("pgm", "image/x-portable-graymap");
        _mimeTypes.Add("pic", "image/pict");
        _mimeTypes.Add("pict", "image/pict");
        _mimeTypes.Add("pkg", "application/x-newton-compatible-pkg");
        _mimeTypes.Add("pko", "application/vnd.ms-pki.pko");
        _mimeTypes.Add("pl", "text/plain");
        _mimeTypes.Add("plx", "application/x-PiXCLscript");
        _mimeTypes.Add("pm4", "application/x-pagemaker");
        _mimeTypes.Add("pm5", "application/x-pagemaker");
        _mimeTypes.Add("pma", "application/x-perfmon");
        _mimeTypes.Add("pmc", "application/x-perfmon");
        _mimeTypes.Add("pm", "image/x-xpixmap");
        _mimeTypes.Add("pml", "application/x-perfmon");
        _mimeTypes.Add("pmr", "application/x-perfmon");
        _mimeTypes.Add("pmw", "application/x-perfmon");
        _mimeTypes.Add("png", "image/png");
        _mimeTypes.Add("pnm", "application/x-portable-anymap");
        _mimeTypes.Add("pot", "application/vnd.ms-powerpoint");
        _mimeTypes.Add("potm", "application/vnd.ms-powerpoint.template.macroEnabled.12");
        _mimeTypes.Add("potx", "application/vnd.openxmlformats-officedocument.presentationml.template");
        _mimeTypes.Add("pov", "model/x-pov");
        _mimeTypes.Add("ppa", "application/vnd.ms-powerpoint");
        _mimeTypes.Add("ppam", "application/vnd.ms-powerpoint.addin.macroEnabled.12");
        _mimeTypes.Add("ppm", "image/x-portable-pixmap");
        _mimeTypes.Add("pps", "application/vnd.ms-powerpoint");
        _mimeTypes.Add("ppsm", "application/vnd.ms-powerpoint.slideshow.macroEnabled.12");
        _mimeTypes.Add("ppsx", "application/vnd.openxmlformats-officedocument.presentationml.slideshow");
        _mimeTypes.Add("ppt", "application/vnd.ms-powerpoint");
        _mimeTypes.Add("pptm", "application/vnd.ms-powerpoint.presentation.macroEnabled.12");
        _mimeTypes.Add("pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation");
        _mimeTypes.Add("ppz", "application/mspowerpoint");
        _mimeTypes.Add("pre", "application/x-freelance");
        _mimeTypes.Add("prf", "application/pics-rules");
        _mimeTypes.Add("prt", "application/pro_eng");
        _mimeTypes.Add("ps", "application/postscript");
        _mimeTypes.Add("p", "text/x-pascal");
        _mimeTypes.Add("pub", "application/x-mspublisher");
        _mimeTypes.Add("pvu", "paleovu/x-pv");
        _mimeTypes.Add("pwz", "application/vnd.ms-powerpoint");
        _mimeTypes.Add("pyc", "applicaiton/x-bytecode.python");
        _mimeTypes.Add("py", "text/x-script.phyton");
        _mimeTypes.Add("qcp", "audio/vnd.qcelp");
        _mimeTypes.Add("qd3d", "x-world/x-3dmf");
        _mimeTypes.Add("qd3", "x-world/x-3dmf");
        _mimeTypes.Add("qif", "image/x-quicktime");
        _mimeTypes.Add("qtc", "video/x-qtc");
        _mimeTypes.Add("qtif", "image/x-quicktime");
        _mimeTypes.Add("qti", "image/x-quicktime");
        _mimeTypes.Add("qt", "video/quicktime");
        _mimeTypes.Add("ra", "audio/x-pn-realaudio");
        _mimeTypes.Add("ram", "audio/x-pn-realaudio");
        _mimeTypes.Add("ras", "application/x-cmu-raster");
        _mimeTypes.Add("rast", "image/cmu-raster");
        _mimeTypes.Add("rexx", "text/x-script.rexx");
        _mimeTypes.Add("rf", "image/vnd.rn-realflash");
        _mimeTypes.Add("rgb", "image/x-rgb");
        _mimeTypes.Add("rm", "application/vnd.rn-realmedia");
        _mimeTypes.Add("rmi", "audio/mid");
        _mimeTypes.Add("rmm", "audio/x-pn-realaudio");
        _mimeTypes.Add("rmp", "audio/x-pn-realaudio");
        _mimeTypes.Add("rng", "application/ringing-tones");
        _mimeTypes.Add("rnx", "application/vnd.rn-realplayer");
        _mimeTypes.Add("roff", "application/x-troff");
        _mimeTypes.Add("rp", "image/vnd.rn-realpix");
        _mimeTypes.Add("rpm", "audio/x-pn-realaudio-plugin");
        _mimeTypes.Add("rss", "application/rss+xml");
        _mimeTypes.Add("rtf", "text/richtext");
        _mimeTypes.Add("rt", "text/richtext");
        _mimeTypes.Add("rtx", "text/richtext");
        _mimeTypes.Add("rv", "video/vnd.rn-realvideo");
        _mimeTypes.Add("s3m", "audio/s3m");
        _mimeTypes.Add("sbk", "application/x-tbook");
        _mimeTypes.Add("scd", "application/x-msschedule");
        _mimeTypes.Add("scm", "application/x-lotusscreencam");
        _mimeTypes.Add("sct", "text/scriptlet");
        _mimeTypes.Add("sdml", "text/plain");
        _mimeTypes.Add("sdp", "application/sdp");
        _mimeTypes.Add("sdr", "application/sounder");
        _mimeTypes.Add("sea", "application/sea");
        _mimeTypes.Add("set", "application/set");
        _mimeTypes.Add("setpay", "application/set-payment-initiation");
        _mimeTypes.Add("setreg", "application/set-registration-initiation");
        _mimeTypes.Add("sgml", "text/sgml");
        _mimeTypes.Add("sgm", "text/sgml");
        _mimeTypes.Add("shar", "application/x-bsh");
        _mimeTypes.Add("sh", "text/x-script.sh");
        _mimeTypes.Add("shtml", "text/html");
        _mimeTypes.Add("sid", "audio/x-psid");
        _mimeTypes.Add("silo", "model/mesh");
        _mimeTypes.Add("sit", "application/x-sit");
        _mimeTypes.Add("skd", "application/x-koan");
        _mimeTypes.Add("skm", "application/x-koan");
        _mimeTypes.Add("skp", "application/x-koan");
        _mimeTypes.Add("skt", "application/x-koan");
        _mimeTypes.Add("sl", "application/x-seelogo");
        _mimeTypes.Add("smi", "application/smil");
        _mimeTypes.Add("smil", "application/smil");
        _mimeTypes.Add("snd", "audio/basic");
        _mimeTypes.Add("sol", "application/solids");
        _mimeTypes.Add("spc", "application/x-pkcs7-certificates");
        _mimeTypes.Add("spl", "application/futuresplash");
        _mimeTypes.Add("spr", "application/x-sprite");
        _mimeTypes.Add("sprite", "application/x-sprite");
        _mimeTypes.Add("spx", "audio/ogg");
        _mimeTypes.Add("src", "application/x-wais-source");
        _mimeTypes.Add("ssi", "text/x-server-parsed-html");
        _mimeTypes.Add("ssm", "application/streamingmedia");
        _mimeTypes.Add("sst", "application/vnd.ms-pki.certstore");
        _mimeTypes.Add("step", "application/step");
        _mimeTypes.Add("s", "text/x-asm");
        _mimeTypes.Add("stl", "application/sla");
        _mimeTypes.Add("stm", "text/html");
        _mimeTypes.Add("stp", "application/step");
        _mimeTypes.Add("sv4cpio", "application/x-sv4cpio");
        _mimeTypes.Add("sv4crc", "application/x-sv4crc");
        _mimeTypes.Add("svf", "image/x-dwg");
        _mimeTypes.Add("svg", "image/svg+xml");
        _mimeTypes.Add("svr", "application/x-world");
        _mimeTypes.Add("swf", "application/x-shockwave-flash");
        _mimeTypes.Add("talk", "text/x-speech");
        _mimeTypes.Add("t", "application/x-troff");
        _mimeTypes.Add("tar", "application/x-tar");
        _mimeTypes.Add("tbk", "application/toolbook");
        _mimeTypes.Add("tcl", "text/x-script.tcl");
        _mimeTypes.Add("tcsh", "text/x-script.tcsh");
        _mimeTypes.Add("tex", "application/x-tex");
        _mimeTypes.Add("texi", "application/x-texinfo");
        _mimeTypes.Add("texinfo", "application/x-texinfo");
        _mimeTypes.Add("text", "text/plain");
        _mimeTypes.Add("tgz", "application/x-compressed");
        _mimeTypes.Add("tiff", "image/tiff");
        _mimeTypes.Add("tif", "image/tiff");
        _mimeTypes.Add("tr", "application/x-troff");
        _mimeTypes.Add("trm", "application/x-msterminal");
        _mimeTypes.Add("ts", "text/x-typescript");
        _mimeTypes.Add("tsi", "audio/tsp-audio");
        _mimeTypes.Add("tsp", "audio/tsplayer");
        _mimeTypes.Add("tsv", "text/tab-separated-values");
        _mimeTypes.Add("ttf", "application/x-font-ttf");
        _mimeTypes.Add("turbot", "image/florian");
        _mimeTypes.Add("txt", "text/plain");
        _mimeTypes.Add("uil", "text/x-uil");
        _mimeTypes.Add("uls", "text/iuls");
        _mimeTypes.Add("unis", "text/uri-list");
        _mimeTypes.Add("uni", "text/uri-list");
        _mimeTypes.Add("unv", "application/i-deas");
        _mimeTypes.Add("uris", "text/uri-list");
        _mimeTypes.Add("uri", "text/uri-list");
        _mimeTypes.Add("ustar", "multipart/x-ustar");
        _mimeTypes.Add("uue", "text/x-uuencode");
        _mimeTypes.Add("uu", "text/x-uuencode");
        _mimeTypes.Add("vcd", "application/x-cdlink");
        _mimeTypes.Add("vcf", "text/vcard");
        _mimeTypes.Add("vcard", "text/vcard");
        _mimeTypes.Add("vcs", "text/x-vCalendar");
        _mimeTypes.Add("vda", "application/vda");
        _mimeTypes.Add("vdo", "video/vdo");
        _mimeTypes.Add("vew", "application/groupwise");
        _mimeTypes.Add("vivo", "video/vivo");
        _mimeTypes.Add("viv", "video/vivo");
        _mimeTypes.Add("vmd", "application/vocaltec-media-desc");
        _mimeTypes.Add("vmf", "application/vocaltec-media-file");
        _mimeTypes.Add("voc", "audio/voc");
        _mimeTypes.Add("vos", "video/vosaic");
        _mimeTypes.Add("vox", "audio/voxware");
        _mimeTypes.Add("vqe", "audio/x-twinvq-plugin");
        _mimeTypes.Add("vqf", "audio/x-twinvq");
        _mimeTypes.Add("vql", "audio/x-twinvq-plugin");
        _mimeTypes.Add("vrml", "application/x-vrml");
        _mimeTypes.Add("vrt", "x-world/x-vrt");
        _mimeTypes.Add("vsd", "application/x-visio");
        _mimeTypes.Add("vst", "application/x-visio");
        _mimeTypes.Add("vsw", "application/x-visio");
        _mimeTypes.Add("w60", "application/wordperfect6.0");
        _mimeTypes.Add("w61", "application/wordperfect6.1");
        _mimeTypes.Add("w6w", "application/msword");
        _mimeTypes.Add("wav", "audio/wav");
        _mimeTypes.Add("wb1", "application/x-qpro");
        _mimeTypes.Add("wbmp", "image/vnd.wap.wbmp");
        _mimeTypes.Add("wcm", "application/vnd.ms-works");
        _mimeTypes.Add("wdb", "application/vnd.ms-works");
        _mimeTypes.Add("web", "application/vnd.xara");
        _mimeTypes.Add("webm", "video/webm");
        _mimeTypes.Add("wiz", "application/msword");
        _mimeTypes.Add("wk1", "application/x-123");
        _mimeTypes.Add("wks", "application/vnd.ms-works");
        _mimeTypes.Add("wmf", "windows/metafile");
        _mimeTypes.Add("wmlc", "application/vnd.wap.wmlc");
        _mimeTypes.Add("wmlsc", "application/vnd.wap.wmlscriptc");
        _mimeTypes.Add("wmls", "text/vnd.wap.wmlscript");
        _mimeTypes.Add("wml", "text/vnd.wap.wml");
        _mimeTypes.Add("wmp", "video/x-ms-wmp");
        _mimeTypes.Add("wmv", "video/x-ms-wmv");
        _mimeTypes.Add("wmx", "video/x-ms-wmx");
        _mimeTypes.Add("woff", "application/x-woff");
        _mimeTypes.Add("word", "application/msword");
        _mimeTypes.Add("wp5", "application/wordperfect");
        _mimeTypes.Add("wp6", "application/wordperfect");
        _mimeTypes.Add("wp", "application/wordperfect");
        _mimeTypes.Add("wpd", "application/wordperfect");
        _mimeTypes.Add("wps", "application/vnd.ms-works");
        _mimeTypes.Add("wq1", "application/x-lotus");
        _mimeTypes.Add("wri", "application/mswrite");
        _mimeTypes.Add("wrl", "application/x-world");
        _mimeTypes.Add("wrz", "model/vrml");
        _mimeTypes.Add("wsc", "text/scriplet");
        _mimeTypes.Add("wsdl", "text/xml");
        _mimeTypes.Add("wsrc", "application/x-wais-source");
        _mimeTypes.Add("wtk", "application/x-wintalk");
        _mimeTypes.Add("wvx", "video/x-ms-wvx");
        _mimeTypes.Add("x3d", "model/x3d+xml");
        _mimeTypes.Add("x3db", "model/x3d+fastinfoset");
        _mimeTypes.Add("x3dv", "model/x3d-vrml");
        _mimeTypes.Add("xaf", "x-world/x-vrml");
        _mimeTypes.Add("xaml", "application/xaml+xml");
        _mimeTypes.Add("xap", "application/x-silverlight-app");
        _mimeTypes.Add("xbap", "application/x-ms-xbap");
        _mimeTypes.Add("xbm", "image/x-xbitmap");
        _mimeTypes.Add("xdr", "video/x-amt-demorun");
        _mimeTypes.Add("xgz", "xgl/drawing");
        _mimeTypes.Add("xht", "application/xhtml+xml");
        _mimeTypes.Add("xhtml", "application/xhtml+xml");
        _mimeTypes.Add("xif", "image/vnd.xiff");
        _mimeTypes.Add("xla", "application/vnd.ms-excel");
        _mimeTypes.Add("xlam", "application/vnd.ms-excel.addin.macroEnabled.12");
        _mimeTypes.Add("xl", "application/excel");
        _mimeTypes.Add("xlb", "application/excel");
        _mimeTypes.Add("xlc", "application/excel");
        _mimeTypes.Add("xld", "application/excel");
        _mimeTypes.Add("xlk", "application/excel");
        _mimeTypes.Add("xll", "application/excel");
        _mimeTypes.Add("xlm", "application/excel");
        _mimeTypes.Add("xls", "application/vnd.ms-excel");
        _mimeTypes.Add("xlsb", "application/vnd.ms-excel.sheet.binary.macroEnabled.12");
        _mimeTypes.Add("xlsm", "application/vnd.ms-excel.sheet.macroEnabled.12");
        _mimeTypes.Add("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        _mimeTypes.Add("xlt", "application/vnd.ms-excel");
        _mimeTypes.Add("xltm", "application/vnd.ms-excel.template.macroEnabled.12");
        _mimeTypes.Add("xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template");
        _mimeTypes.Add("xlv", "application/excel");
        _mimeTypes.Add("xlw", "application/excel");
        _mimeTypes.Add("xm", "audio/xm");
        _mimeTypes.Add("xml", "text/xml");
        _mimeTypes.Add("xmz", "xgl/movie");
        _mimeTypes.Add("xof", "x-world/x-vrml");
        _mimeTypes.Add("xpi", "application/x-xpinstall");
        _mimeTypes.Add("xpix", "application/x-vnd.ls-xpix");
        _mimeTypes.Add("xpm", "image/xpm");
        _mimeTypes.Add("xps", "application/vnd.ms-xpsdocument");
        _mimeTypes.Add("x-png", "image/png");
        _mimeTypes.Add("xsd", "text/xml");
        _mimeTypes.Add("xsl", "text/xml");
        _mimeTypes.Add("xslt", "text/xml");
        _mimeTypes.Add("xsr", "video/x-amt-showrun");
        _mimeTypes.Add("xwd", "image/x-xwd");
        _mimeTypes.Add("xyz", "chemical/x-pdb");
        _mimeTypes.Add("z", "application/x-compressed");
        _mimeTypes.Add("zip", "application/zip");
        _mimeTypes.Add("zsh", "text/x-script.zsh");
    }

    public Dictionary<string, string> GetMimeTypes() => _mimeTypes;
}