//Maya ASCII 2017 scene
//Name: head.ma
//Last modified: Thu, Feb 02, 2017 10:05:46 AM
//Codeset: 1252
requires maya "2017";
requires -dataType "HIKCharacter" -dataType "HIKCharacterState" -dataType "HIKEffectorState"
		 -dataType "HIKPropertySetState" "mayaHIK" "1.0_HIK_2016.5";
requires "stereoCamera" "10.0";
requires "stereoCamera" "10.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Business Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "education";
createNode transform -n "pPlane5";
	rename -uid "7630365A-4AF3-387C-47ED-3A8375A5C84A";
	setAttr ".t" -type "double3" -2.9266838342796628 0 0 ;
createNode mesh -n "pPlaneShape5" -p "pPlane5";
	rename -uid "EBF8192A-4399-6A07-E2D3-FB95998E5A13";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode polyExtrudeFace -n "polyExtrudeFace1";
	rename -uid "1CF39C3A-41E7-8CC9-5498-8F905828DD0E";
	setAttr ".ics" -type "componentList" 1 "f[0:34]";
	setAttr ".ix" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 -2.9266838342796628 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pvt" -type "float3" -2.9266839 1.1102233e-017 -0.050000012 ;
	setAttr ".rs" 43204;
	setAttr ".lt" -type "double3" 0 7.2576416804116427e-018 0.28268551236749057 ;
	setAttr ".ls" -type "double3" 1 1 0.5414118695762794 ;
	setAttr ".c[0]"  0 1 1;
	setAttr ".cbn" -type "double3" -3.2266838462005918 -6.6613384124487353e-017 -0.40000003576278687 ;
	setAttr ".cbx" -type "double3" -2.6266838223587339 8.8817849910946404e-017 0.30000001192092896 ;
createNode deleteComponent -n "deleteComponent2";
	rename -uid "EF1A67CC-4413-B4C7-046F-F08285711DDD";
	setAttr ".dc" -type "componentList" 1 "f[33]";
createNode deleteComponent -n "deleteComponent1";
	rename -uid "AECF7035-4623-6DB9-678E-EBB6CD68AB70";
	setAttr ".dc" -type "componentList" 8 "f[0:22]" "f[27:31]" "f[38:41]" "f[48:51]" "f[58:61]" "f[68:71]" "f[78:83]" "f[86:99]";
createNode polyPlane -n "polyPlane1";
	rename -uid "8EA7C1DD-4724-FF27-2C4C-91AFBE40F5D4";
	setAttr ".cuv" 2;
createNode materialInfo -n "materialInfo7";
	rename -uid "E4B5B1F7-4ECC-E9B0-A629-35ACE37B4D49";
createNode shadingEngine -n "lambert7SG";
	rename -uid "81C837D7-4DBA-3591-2BF2-BDAA820CCD0E";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode lambert -n "lambert7";
	rename -uid "269506E3-4C18-60DC-1C04-4C84D0950E66";
createNode file -n "file5";
	rename -uid "1139DCEB-444A-B40C-D25C-FBB600D13192";
	setAttr ".ftn" -type "string" "E:/Human Visualization VR/HeadSubtransparent.png";
	setAttr ".cs" -type "string" "sRGB";
createNode place2dTexture -n "place2dTexture12";
	rename -uid "BFC9F98D-4673-F8CA-1C9E-65B9C0F01308";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "D8F7ABA9-414D-D696-CAC3-B98BF356361C";
	setAttr -s 15 ".lnk";
	setAttr -s 15 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 6 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 19 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 12 ".u";
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
	setAttr -s 12 ".tx";
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "polyExtrudeFace1.out" "pPlaneShape5.i";
connectAttr "deleteComponent2.og" "polyExtrudeFace1.ip";
connectAttr "pPlaneShape5.wm" "polyExtrudeFace1.mp";
connectAttr "deleteComponent1.og" "deleteComponent2.ig";
connectAttr "polyPlane1.out" "deleteComponent1.ig";
connectAttr "lambert7SG.msg" "materialInfo7.sg";
connectAttr "lambert7.msg" "materialInfo7.m";
connectAttr "file5.msg" "materialInfo7.t" -na;
connectAttr "lambert7.oc" "lambert7SG.ss";
connectAttr "pPlaneShape5.iog" "lambert7SG.dsm" -na;
connectAttr "file5.oc" "lambert7.c";
connectAttr "file5.ot" "lambert7.it";
connectAttr ":defaultColorMgtGlobals.cme" "file5.cme";
connectAttr ":defaultColorMgtGlobals.cfe" "file5.cmcf";
connectAttr ":defaultColorMgtGlobals.cfp" "file5.cmcp";
connectAttr ":defaultColorMgtGlobals.wsn" "file5.ws";
connectAttr "place2dTexture12.c" "file5.c";
connectAttr "place2dTexture12.tf" "file5.tf";
connectAttr "place2dTexture12.rf" "file5.rf";
connectAttr "place2dTexture12.mu" "file5.mu";
connectAttr "place2dTexture12.mv" "file5.mv";
connectAttr "place2dTexture12.s" "file5.s";
connectAttr "place2dTexture12.wu" "file5.wu";
connectAttr "place2dTexture12.wv" "file5.wv";
connectAttr "place2dTexture12.re" "file5.re";
connectAttr "place2dTexture12.of" "file5.of";
connectAttr "place2dTexture12.r" "file5.ro";
connectAttr "place2dTexture12.n" "file5.n";
connectAttr "place2dTexture12.vt1" "file5.vt1";
connectAttr "place2dTexture12.vt2" "file5.vt2";
connectAttr "place2dTexture12.vt3" "file5.vt3";
connectAttr "place2dTexture12.vc1" "file5.vc1";
connectAttr "place2dTexture12.o" "file5.uv";
connectAttr "place2dTexture12.ofs" "file5.fs";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert7SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert7SG.message" ":defaultLightSet.message";
connectAttr "lambert7SG.pa" ":renderPartition.st" -na;
connectAttr "lambert7.msg" ":defaultShaderList1.s" -na;
connectAttr "place2dTexture12.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "file5.msg" ":defaultTextureList1.tx" -na;
// End of head.ma
