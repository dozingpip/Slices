//Maya ASCII 2017 scene
//Name: coneboop.ma
//Last modified: Tue, Jan 31, 2017 09:09:18 AM
//Codeset: 1252
requires maya "2017";
requires -nodeType "gameFbxExporter" "gameFbxExporter" "1.0";
requires "stereoCamera" "10.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Business Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "education";
createNode transform -s -n "persp";
	rename -uid "FCEC5839-4E91-8505-9DA0-CEA3EA49D4EA";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 43.770379542232945 143.1168726615972 264.39545164305446 ;
	setAttr ".r" -type "double3" -25.538352729600984 9.4000000000000785 0 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "666BEA38-4A8A-C5A0-D304-689F2522B154";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 297.0131425372806;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" -4.8444626834509563e-006 15.07 -7.2666940234000776e-006 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "A2125829-434D-A3EA-BA97-A78DF10BE49F";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 1000.1 0 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "754683E6-4381-3256-E0E8-03A3A6FA3EA7";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	rename -uid "31283E36-4D4C-12CD-50FF-E292015BFDB5";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 1000.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "5E7797F4-4A98-A7C3-4C0F-B6A0F8512371";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	rename -uid "7DC6C2BA-424B-B752-8D7C-5095FF13A392";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 1000.1 0 0 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "F589581D-4B9A-462E-EBDE-F7B6B8002557";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 1000.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "pCone1";
	rename -uid "CE86E7A1-433F-A953-8C56-C99A01AEFAD6";
createNode mesh -n "pConeShape1" -p "pCone1";
	rename -uid "1AB3C014-475C-98FC-8139-63A712217B38";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.49999997019767761 0.49999994039535522 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode transform -n "persp1";
	rename -uid "98B42CD5-421F-FEEC-EFA8-A8BF4AADD8D4";
	setAttr ".t" -type "double3" 43.770379542232945 143.1168726615972 264.39545164305446 ;
	setAttr -l on ".tx";
	setAttr -l on ".ty";
	setAttr -l on ".tz";
	setAttr ".r" -type "double3" -25.538352729600984 9.4000000000000785 0 ;
	setAttr -l on ".rx";
	setAttr -l on ".ry";
	setAttr -l on ".rz";
createNode camera -n "persp1Shape" -p "persp1";
	rename -uid "0DB7D6F3-4981-7C30-57D5-0F9A3FF561B5";
	setAttr -k off ".v";
	setAttr ".fl" 34.999999999999993;
	setAttr -l on ".coi" 297.0131425372806;
	setAttr -l on ".ow";
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".tp" -type "double3" -4.8444626834509563e-006 15.07 -7.2666940234000776e-006 ;
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode lightLinker -s -n "lightLinker1";
	rename -uid "D8F7ABA9-414D-D696-CAC3-B98BF356361C";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
createNode shapeEditorManager -n "shapeEditorManager";
	rename -uid "437275EC-433C-BA19-9458-829A681898C8";
createNode poseInterpolatorManager -n "poseInterpolatorManager";
	rename -uid "D9AB70BA-4B65-BAD2-280F-D8AB980329D0";
createNode displayLayerManager -n "layerManager";
	rename -uid "9AEB5025-4A08-808A-556F-6F9D5D37DACB";
createNode displayLayer -n "defaultLayer";
	rename -uid "9B7DF164-4929-98F2-6091-E3BDD2AD8420";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "2D2EE75C-4553-A6D8-5AB0-B7B615DC231A";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "1FAABE1C-467C-CE97-8301-1BBD476EEFAC";
	setAttr ".g" yes;
createNode polyCone -n "polyCone1";
	rename -uid "96F9E2A7-4B31-B10A-ADFD-3EBF548C6C4B";
	setAttr ".cuv" 3;
createNode animCurveTL -n "pCone1_translateX";
	rename -uid "DB454B35-48DB-B1E0-6761-B09BF7EEC4BB";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 0 93 0;
createNode animCurveTL -n "pCone1_translateY";
	rename -uid "4E7A12FF-448A-69D0-F74B-7BA6CB1C609C";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 15.07 93 15.07;
createNode animCurveTL -n "pCone1_translateZ";
	rename -uid "29CEEA4C-425A-1EB5-DB7C-E09C3D1C5373";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 0 93 0;
createNode animCurveTU -n "pCone1_visibility";
	rename -uid "8FB52E68-4A1A-AD9F-78E5-7DAABF37E0BA";
	setAttr ".tan" 9;
	setAttr -s 2 ".ktv[0:1]"  1 1 93 1;
	setAttr -s 2 ".kot[0:1]"  5 5;
createNode animCurveTA -n "pCone1_rotateX";
	rename -uid "93DDD684-4818-58B8-3CBD-90BE8DD0C108";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 0 93 0;
createNode animCurveTA -n "pCone1_rotateY";
	rename -uid "C367BCE2-4CAE-7307-A6A4-8582D075E5C9";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 0 93 0;
createNode animCurveTA -n "pCone1_rotateZ";
	rename -uid "352C33A0-4D21-1437-D9C5-F29C7205EC07";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 0 93 0;
createNode animCurveTU -n "pCone1_scaleX";
	rename -uid "6054E6AA-4F7A-2858-0D55-EEB19B4A1CD7";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 15.06991995032598 93 40.638298429227717;
createNode animCurveTU -n "pCone1_scaleY";
	rename -uid "0D0B02F4-4153-3B41-D114-40AAA69F6FD7";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 15.06991995032598 93 40.638298429227717;
createNode animCurveTU -n "pCone1_scaleZ";
	rename -uid "F216B62D-40C4-EAFE-CAB1-F7BDACD17412";
	setAttr ".tan" 18;
	setAttr -s 2 ".ktv[0:1]"  1 15.06991995032598 93 40.638298429227717;
createNode blinn -n "blinn1";
	rename -uid "2C54E4FE-42E9-971E-E6B0-4EB43B4A4B30";
	setAttr ".c" -type "float3" 0.5783 0.1247 0.1247 ;
	setAttr ".it" -type "float3" 0.32467532 0.32467532 0.32467532 ;
createNode shadingEngine -n "blinn1SG";
	rename -uid "AD6A5AAC-4E50-9286-867A-57B21133580F";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo1";
	rename -uid "E788D465-434F-B37C-5AE7-03ABE500C097";
createNode gameFbxExporter -n "gameExporterPreset1";
	rename -uid "CC492FFF-4E7B-D7CB-D6FB-A9A3AC1DFD33";
	setAttr ".pn" -type "string" "Model Default";
	setAttr ".ils" yes;
	setAttr ".ilu" yes;
	setAttr ".ean" yes;
	setAttr ".ebm" yes;
	setAttr ".inc" yes;
	setAttr ".fv" -type "string" "FBX201600";
	setAttr ".exp" -type "string" "C:/Users/Student/Documents/pocket-rocket-2/Assets";
	setAttr ".exf" -type "string" "cooone";
createNode gameFbxExporter -n "gameExporterPreset2";
	rename -uid "8541BEE4-4607-CFC4-554B-74AF10C90358";
	setAttr ".pn" -type "string" "Anim Default";
	setAttr ".ils" yes;
	setAttr ".eti" 2;
	setAttr ".spt" 2;
	setAttr ".ic" no;
	setAttr ".ebm" yes;
	setAttr ".fv" -type "string" "FBX201600";
createNode gameFbxExporter -n "gameExporterPreset3";
	rename -uid "288025E2-4700-B891-478E-CDB1EF03294D";
	setAttr ".pn" -type "string" "TE Anim Default";
	setAttr ".ils" yes;
	setAttr ".eti" 3;
	setAttr ".ebm" yes;
	setAttr ".fv" -type "string" "FBX201600";
select -ne :time1;
	setAttr ".o" 120;
	setAttr ".unw" 120;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
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
connectAttr "pCone1_translateX.o" "pCone1.tx";
connectAttr "pCone1_translateY.o" "pCone1.ty";
connectAttr "pCone1_translateZ.o" "pCone1.tz";
connectAttr "pCone1_visibility.o" "pCone1.v";
connectAttr "pCone1_rotateX.o" "pCone1.rx";
connectAttr "pCone1_rotateY.o" "pCone1.ry";
connectAttr "pCone1_rotateZ.o" "pCone1.rz";
connectAttr "pCone1_scaleX.o" "pCone1.sx";
connectAttr "pCone1_scaleY.o" "pCone1.sy";
connectAttr "pCone1_scaleZ.o" "pCone1.sz";
connectAttr "polyCone1.out" "pConeShape1.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "blinn1.oc" "blinn1SG.ss";
connectAttr "pConeShape1.iog" "blinn1SG.dsm" -na;
connectAttr "blinn1SG.msg" "materialInfo1.sg";
connectAttr "blinn1.msg" "materialInfo1.m";
connectAttr "blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "blinn1.msg" ":defaultShaderList1.s" -na;
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
// End of coneboop.ma
