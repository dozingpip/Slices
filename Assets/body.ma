//Maya ASCII 2017 scene
//Name: body.ma
//Last modified: Tue, Feb 07, 2017 09:07:52 AM
//Codeset: 1252
requires maya "2017";
requires "stereoCamera" "10.0";
requires "stereoCamera" "10.0";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201606150345-997974";
fileInfo "osv" "Microsoft Windows 8 Business Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "education";
createNode transform -n "pPlane7";
	rename -uid "39752480-4943-926D-517F-EEA087866EA4";
createNode mesh -n "pPlaneShape7" -p "pPlane7";
	rename -uid "D1F393A2-4953-5ADF-3172-86838163969B";
	setAttr -k off ".v";
	setAttr -s 2 ".iog[0].og";
	setAttr ".iog[0].og[0].gcl" -type "componentList" 1 "f[0:57]";
	setAttr ".iog[0].og[1].gcl" -type "componentList" 1 "f[58:84]";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.50059406645596027 0.54023906588554382 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 131 ".uvst[0].uvsp[0:130]" -type "float2" 0.1 0.40000001 0.90000004
		 0.40000001 0.1 0.5 0.2 0.5 0.30000001 0.5 0.40000001 0.5 0.5 0.5 0.60000002 0.5 0.69999999
		 0.5 0.80000001 0.5 0.90000004 0.5 0.2 0.60000002 0.30000001 0.60000002 0.40000001
		 0.60000002 0.5 0.60000002 0.60000002 0.60000002 0.69999999 0.60000002 0.80000001
		 0.60000002 0.90000004 0.60000002 0.80000001 0.69999999 0.80000007 0.73240781 0.83346993
		 0.69999999 0.94864511 0.5 0.83975732 0.40000001 0.73575151 0.60000002 0.76404083
		 0.69999999 0.8251971 0.72381902 0.88043606 0.641105 0.940171 0.53605103 0.92785197
		 0.42543399 0.82067901 0.45257896 0.75130701 0.65367997 0.77987707 0.72504902 0.2
		 0.66781759 0.27025521 0.60000002 0.2631959 0.5 0.19999999 0.4423511 0.1684871 0.39999998
		 0.1 0.34807032 0.068589099 0.40000001 0.057550002 0.5 0.099999994 0.5633679 0.1339317
		 0.60000002 0.259123 0.65140504 0.052543018 0.44179398 0.072479993 0.53565603 0.2631959
		 0.5 0.30000001 0.5 0.30000001 0.60000002 0.27025521 0.60000002 0.2 0.60000002 0.2
		 0.5 0.40000001 0.5 0.40000001 0.60000002 0.5 0.5 0.5 0.60000002 0.60000002 0.5 0.60000002
		 0.60000002 0.69999999 0.5 0.69999999 0.60000002 0.73575151 0.60000002 0.80000001
		 0.5 0.80000001 0.60000002 0.90000004 0.5 0.90000004 0.60000002 0.80000001 0.69999999
		 0.83346993 0.69999999 0.8251971 0.72381902 0.80000007 0.73240781 0.88043606 0.641105
		 0.94864511 0.5 0.940171 0.53605103 0.90000004 0.40000001 0.92785197 0.42543399 0.82067901
		 0.45257896 0.83975732 0.40000001 0.76404083 0.69999999 0.75130701 0.65367997 0.77987707
		 0.72504902 0.259123 0.65140504 0.2 0.66781759 0.19999999 0.4423511 0.1 0.40000001
		 0.1684871 0.39999998 0.1 0.5 0.1 0.34807032 0.068589099 0.40000001 0.057550002 0.5
		 0.052543018 0.44179398 0.099999994 0.5633679 0.072479993 0.53565603 0.1339317 0.60000002
		 0.2631959 0.5 0.30000001 0.5 0.30000001 0.60000002 0.27025521 0.60000002 0.40000001
		 0.5 0.40000001 0.60000002 0.5 0.5 0.5 0.60000002 0.60000002 0.5 0.60000002 0.60000002
		 0.69999999 0.5 0.69999999 0.60000002 0.73575151 0.60000002 0.80000001 0.5 0.83346993
		 0.69999999 0.8251971 0.72381902 0.80000007 0.73240781 0.90000004 0.60000002 0.88043606
		 0.641105 0.94864511 0.5 0.940171 0.53605103 0.90000004 0.40000001 0.92785197 0.42543399
		 0.82067901 0.45257896 0.83975732 0.40000001 0.76404083 0.69999999 0.75130701 0.65367997
		 0.77987707 0.72504902 0.259123 0.65140504 0.2 0.66781759 0.19999999 0.4423511 0.1684871
		 0.39999998 0.1 0.34807032 0.068589099 0.40000001 0.057550002 0.5 0.052543018 0.44179398
		 0.099999994 0.5633679 0.072479993 0.53565603 0.1339317 0.60000002;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 92 ".pt[0:91]" -type "float3"  0 -0.00019423754 -0.00015869697 
		0 -0.00018874058 -0.00015419174 0 -1.4162568e-005 -0.00015853303 0 -1.4162568e-005 
		-0.00015853303 0 -1.4162568e-005 -0.00015853303 0 -1.4162568e-005 -0.00015853303 
		0 -1.4135016e-005 -0.0001582184 0 -1.4093253e-005 -0.00015775199 0 -1.4024815e-005 
		-0.00015697246 0 -1.3928675e-005 -0.00015588912 0 -1.3805666e-005 -0.00015449744 
		0 0.00016591577 -0.000158372 0 0.00016591577 -0.000158372 0 0.00016591577 -0.000158372 
		0 0.00016591577 -0.000158372 0 0.00016526457 -0.00015774746 0 0.00016444721 -0.00015697186 
		0 0.00016330868 -0.00015588423 0 0.0001618525 -0.00015450065 0 0.00034022232 -0.00015557496 
		0 0.00039761054 -0.00015552323 0 0.00033928058 -0.0001551453 0 -1.3736748e-005 -0.00015371655 
		0 -0.00018980278 -0.00015506492 0 0.00016407673 -0.00015661611 0 0.0003411471 -0.00015599892 
		0 0.00038134368 -0.00015511073 0 0.00023445401 -0.00015469313 0 4.9286104e-005 -0.00015389243 
		0 -0.00014393366 -0.00015382955 0 -9.762698e-005 -0.00015553096 0 0.00025932342 -0.00015632357 
		0 0.00038495762 -0.00015568807 0 0.00028804343 -0.00015826701 0 0.00016591577 -0.000158372 
		0 -1.4162568e-005 -0.00015853303 0 -0.0001179769 -0.00015862679 0 -0.00019423754 
		-0.00015869697 0 -0.00028776057 -0.00015878215 0 -0.00019423754 -0.00015869697 0 
		-1.4162568e-005 -0.00015853303 0 9.9951678e-005 -0.00015843174 0 0.00016591577 -0.000158372 
		0 0.00025849306 -0.00015828584 0 -0.00011897949 -0.00015862919 0 5.0046379e-005 -0.00015847522 
		0 -1.4448277e-005 0.00015850517 0 -1.4448277e-005 0.00015850517 0 0.0001656299 0.00015866829 
		0 0.0001656299 0.00015866829 0 0.0001656299 0.00015866829 0 -1.4448277e-005 0.00015850517 
		0 -1.4448277e-005 0.00015850517 0 0.0001656299 0.00015866829 0 -1.4419409e-005 0.0001581955 
		0 0.0001656299 0.00015866829 0 -1.4376392e-005 0.00015772572 0 0.00016497816 0.00015804415 
		0 -1.43047e-005 0.00015695082 0 0.00016416336 0.00015726475 0 0.00016380147 0.00015690961 
		0 -1.4204799e-005 0.00015586131 0 0.00016303032 0.00015617543 0 -1.4077135e-005 0.00015447536 
		0 0.00016158223 0.00015478444 0 0.00033994581 0.00015617747 0 0.00033900409 0.00015574388 
		0 0.00038107231 0.000155783 0 0.0003973312 0.00015622949 0 0.00023418362 0.00015510283 
		0 -1.400505e-005 0.00015369224 0 4.9016373e-005 0.00015397982 0 -0.00014420367 0.00015358184 
		0 -0.00018901122 0.00015386083 0 -9.7903641e-005 0.00015536032 0 -0.00019007793 0.00015473241 
		0 0.00025904388 0.00015678507 0 0.0003408668 0.0001566045 0 0.00038469437 0.00015637313 
		0 0.00025820406 0.00015875284 0 0.00028776057 0.00015877865 0 -0.00011826363 0.00015841388 
		0 -0.00019452599 0.00015834591 0 -0.00019452599 0.00015834591 0 -1.4448277e-005 0.00015850517 
		0 -0.00028804553 0.00015826365 0 -0.00019452599 0.00015834987 0 -0.00011926629 0.00015841694 
		0 -1.4448256e-005 0.00015850704 0 4.9760449e-005 0.00015856313 0 9.966558e-005 0.00015861055 
		0 0.00016563386 0.00015867018;
	setAttr -s 92 ".vt[0:91]"  -0.40000001 -2.2204459e-017 0.10000002 0.40000004 -2.2204459e-017 0.10000002
		 -0.40000001 0 0 -0.30000001 0 0 -0.19999999 0 0 -0.099999994 0 0 0 0 0 0.10000002 0 0
		 0.19999999 0 0 0.30000001 0 0 0.40000004 0 0 -0.30000001 2.2204466e-017 -0.10000002
		 -0.19999999 2.2204466e-017 -0.10000002 -0.099999994 2.2204466e-017 -0.10000002 0 2.2204466e-017 -0.10000002
		 0.10000002 2.2204466e-017 -0.10000002 0.19999999 2.2204466e-017 -0.10000002 0.30000001 2.2204466e-017 -0.10000002
		 0.40000004 2.2204466e-017 -0.10000002 0.30000001 4.4408918e-017 -0.19999993 0.30000001 5.1604897e-017 -0.23240781
		 0.33346993 4.4408918e-017 -0.19999993 0.44864511 0 0 0.33975732 -2.2204459e-017 0.10000002
		 0.23575149 2.2204466e-017 -0.10000002 0.2640408 4.4408918e-017 -0.19999993 0.32519701 0 -0.22381902
		 0.380436 0 -0.14110506 0.440171 0 -0.036051035 0.427852 0 0.074566007 0.32067901 0 0.047420979
		 0.25130701 0 -0.15367997 0.27987701 0 -0.22504902 -0.30000001 3.7262991e-017 -0.16781759
		 -0.22974479 2.2204466e-017 -0.10000002 -0.2368041 0 0 -0.30000001 -1.2800626e-017 0.057648897
		 -0.3315129 -2.2204459e-017 0.10000002 -0.40000001 -3.3735168e-017 0.15192968 -0.43141091 -2.2204459e-017 0.10000002
		 -0.44244999 0 0 -0.39999998 1.4070503e-017 -0.063367963 -0.36606833 2.2204466e-017 -0.10000002
		 -0.240877 0 -0.15140498 -0.44745699 0 0.058206022 -0.42752001 0 -0.035655975 -0.2368041 0.17605634 0
		 -0.19999999 0.17605634 0 -0.19999999 0.17605634 -0.10000002 -0.22974479 0.17605634 -0.10000002
		 -0.30000001 0.17605634 -0.10000002 -0.30000001 0.17605634 0 -0.099999994 0.17605634 0
		 -0.099999994 0.17605634 -0.10000002 0 0.17605634 0 0 0.17605634 -0.10000002 0.10000002 0.17605634 0
		 0.10000002 0.17605634 -0.10000002 0.19999999 0.17605634 0 0.19999999 0.17605634 -0.10000002
		 0.23575149 0.17605634 -0.10000002 0.30000001 0.17605634 0 0.30000001 0.17605634 -0.10000002
		 0.40000004 0.17605634 0 0.40000004 0.17605636 -0.10000002 0.30000001 0.17605634 -0.19999993
		 0.33346993 0.17605636 -0.19999993 0.32519701 0.17605636 -0.22381902 0.30000001 0.17605636 -0.23240781
		 0.380436 0.17605636 -0.14110506 0.44864511 0.17605636 0 0.440171 0.17605636 -0.036051035
		 0.427852 0.17605636 0.074566007 0.40000004 0.17605636 0.10000002 0.32067901 0.17605634 0.047420979
		 0.33975732 0.17605634 0.10000002 0.25130701 0.17605634 -0.15367997 0.2640408 0.17605636 -0.19999993
		 0.27987701 0.17605636 -0.22504902 -0.240877 0.17605634 -0.15140498 -0.30000001 0.17605636 -0.16781759
		 -0.30000001 0.17605634 0.057648897 -0.40000001 0.17605634 0.10000002 -0.3315129 0.17605634 0.10000002
		 -0.40000001 0.17605634 0 -0.40000001 0.17605636 0.15192968 -0.43141091 0.17605636 0.10000002
		 -0.44745699 0.17605634 0.058206022 -0.44244999 0.17605636 0 -0.42752001 0.17605636 -0.035655975
		 -0.39999998 0.17605636 -0.063367963 -0.36606833 0.17605636 -0.10000002;
	setAttr -s 175 ".ed";
	setAttr ".ed[0:165]"  0 37 1 0 2 1 1 10 1 2 3 1 2 41 1 3 35 1 3 11 1 4 5 0
		 4 12 1 5 6 0 5 13 1 6 7 0 6 14 1 7 8 0 7 15 1 8 9 0 8 16 1 9 10 1 9 17 1 10 22 1
		 10 18 1 11 34 1 11 33 1 12 13 0 13 14 0 14 15 0 15 16 0 16 24 0 17 18 1 17 19 1 19 21 1
		 19 20 1 23 1 0 24 17 1 25 19 1 20 26 0 26 21 0 21 27 0 27 18 0 18 28 0 28 22 0 22 29 0
		 29 1 0 23 30 0 30 9 0 24 31 0 31 25 0 25 32 0 32 20 0 34 12 0 35 4 0 36 3 1 38 0 1
		 39 0 1 40 2 1 42 11 1 33 43 0 43 34 0 35 36 0 36 37 0 37 38 0 38 39 0 39 44 0 44 40 0
		 40 45 0 45 41 0 41 42 0 42 33 0 35 46 0 4 47 1 46 47 0 12 48 1 47 48 1 34 49 0 49 48 0
		 50 49 1 51 50 1 51 46 1 5 52 1 47 52 0 13 53 1 52 53 1 48 53 0 6 54 1 52 54 0 14 55 1
		 54 55 1 53 55 0 7 56 1 54 56 0 15 57 1 56 57 1 55 57 0 8 58 1 56 58 0 16 59 1 58 59 1
		 57 59 0 24 60 0 59 60 0 9 61 0 58 61 0 61 62 1 60 62 1 61 63 1 18 64 1 63 64 1 62 64 1
		 21 66 1 65 66 1 26 67 0 67 66 0 20 68 0 68 67 0 65 68 1 27 69 1 69 64 0 66 69 0 62 65 1
		 22 70 1 63 70 1 28 71 1 71 70 0 64 71 0 29 72 0 1 73 0 72 73 0 70 72 0 73 63 1 30 74 1
		 74 61 0 23 75 0 75 74 0 75 73 0 31 76 1 25 77 1 76 77 0 60 76 0 77 65 1 32 78 0 78 68 0
		 77 78 0 43 79 0 79 49 0 33 80 0 80 79 0 50 80 1 36 81 1 46 81 0 81 51 1 37 83 1 82 83 1
		 81 83 0 84 51 1 82 84 1 38 85 0 83 85 0 85 82 1 39 86 1 85 86 0 86 82 1 44 87 1 40 88 1
		 87 88 0 86 87 0 88 84 1;
	setAttr ".ed[166:174]" 45 89 1 41 90 1 89 90 0 88 89 0 84 90 1 42 91 1 91 50 1
		 90 91 0 91 80 0;
	setAttr -s 85 -ch 350 ".fc[0:84]" -type "polyFaces" 
		f 6 70 72 -75 -76 -77 77
		mu 0 6 92 93 94 95 11 3
		f 4 79 81 -83 -73
		mu 0 4 93 96 97 94
		f 4 84 86 -88 -82
		mu 0 4 96 98 99 97
		f 4 89 91 -93 -87
		mu 0 4 98 100 101 99
		f 4 94 96 -98 -92
		mu 0 4 100 102 103 101
		f 5 -100 -97 101 102 -104
		mu 0 5 104 103 102 105 17
		f 4 104 106 -108 -103
		mu 0 4 105 10 18 17
		f 4 109 -112 -114 -115
		mu 0 4 19 106 107 108
		f 5 107 -117 -118 -110 -119
		mu 0 5 17 109 110 106 19
		f 4 120 -123 -124 -107
		mu 0 4 10 111 112 109
		f 4 -127 -128 -121 -129
		mu 0 4 113 114 111 10
		f 5 -131 -133 133 128 -105
		mu 0 5 105 115 116 113 10
		f 5 -137 -138 103 118 -139
		mu 0 5 117 118 104 17 19
		f 4 -141 -142 138 114
		mu 0 4 108 119 117 19
		f 4 75 -144 -146 -147
		mu 0 4 11 95 120 121
		f 3 -149 -78 -150
		mu 0 3 122 92 3
		f 5 151 -153 149 -154 -155
		mu 0 5 0 123 122 3 2
		f 3 -157 -152 -158
		mu 0 3 124 123 0
		f 3 -160 157 -161
		mu 0 3 125 124 0
		f 5 -164 -165 160 154 -166
		mu 0 5 126 127 125 0 2
		f 4 -169 -170 165 170
		mu 0 4 128 129 126 2
		f 5 153 76 -173 -174 -171
		mu 0 5 2 3 11 130 128
		f 3 -175 172 146
		mu 0 3 121 130 11
		f 6 -6 6 21 49 -9 -51
		mu 0 6 46 51 50 49 48 47
		f 4 8 23 -11 -8
		mu 0 4 47 48 53 52
		f 4 10 24 -13 -10
		mu 0 4 52 53 55 54
		f 4 12 25 -15 -12
		mu 0 4 54 55 57 56
		f 4 14 26 -17 -14
		mu 0 4 56 57 59 58
		f 5 33 -19 -16 16 27
		mu 0 5 60 62 61 58 59
		f 4 18 28 -21 -18
		mu 0 4 61 62 64 63
		f 4 31 35 36 -31
		mu 0 4 65 68 67 66
		f 5 29 30 37 38 -29
		mu 0 5 62 65 66 69 64
		f 4 20 39 40 -20
		mu 0 4 63 64 71 70
		f 4 2 19 41 42
		mu 0 4 72 63 70 73
		f 5 17 -3 -33 43 44
		mu 0 5 61 63 72 75 74
		f 5 34 -30 -34 45 46
		mu 0 5 76 65 62 60 77
		f 4 -32 -35 47 48
		mu 0 4 68 65 76 78
		f 4 22 56 57 -22
		mu 0 4 50 80 79 49
		f 3 51 5 58
		mu 0 3 81 51 46
		f 5 1 3 -52 59 -1
		mu 0 5 82 84 51 81 83
		f 3 52 0 60
		mu 0 3 85 82 83
		f 3 53 -53 61
		mu 0 3 86 82 85
		f 5 54 -2 -54 62 63
		mu 0 5 87 84 82 86 88
		f 4 -5 -55 64 65
		mu 0 4 89 84 87 90
		f 5 4 66 55 -7 -4
		mu 0 5 84 89 91 50 51
		f 3 -23 -56 67
		mu 0 3 80 50 91
		f 4 50 69 -71 -69
		mu 0 4 35 4 93 92
		f 4 -50 73 74 -72
		mu 0 4 12 34 95 94
		f 4 7 78 -80 -70
		mu 0 4 4 5 96 93
		f 4 -24 71 82 -81
		mu 0 4 13 12 94 97
		f 4 9 83 -85 -79
		mu 0 4 5 6 98 96
		f 4 -25 80 87 -86
		mu 0 4 14 13 97 99
		f 4 11 88 -90 -84
		mu 0 4 6 7 100 98
		f 4 -26 85 92 -91
		mu 0 4 15 14 99 101
		f 4 13 93 -95 -89
		mu 0 4 7 8 102 100
		f 4 -27 90 97 -96
		mu 0 4 16 15 101 103
		f 4 -28 95 99 -99
		mu 0 4 24 16 103 104
		f 4 15 100 -102 -94
		mu 0 4 8 9 105 102
		f 4 -37 110 111 -109
		mu 0 4 21 26 107 106
		f 4 -36 112 113 -111
		mu 0 4 26 20 108 107
		f 4 -39 115 116 -106
		mu 0 4 18 27 110 109
		f 4 -38 108 117 -116
		mu 0 4 27 21 106 110
		f 4 -41 121 122 -120
		mu 0 4 22 28 112 111
		f 4 -40 105 123 -122
		mu 0 4 28 18 109 112
		f 4 -43 124 126 -126
		mu 0 4 1 29 114 113
		f 4 -42 119 127 -125
		mu 0 4 29 22 111 114
		f 4 -45 129 130 -101
		mu 0 4 9 30 115 105
		f 4 -44 131 132 -130
		mu 0 4 30 23 116 115
		f 4 32 125 -134 -132
		mu 0 4 23 1 113 116
		f 4 -47 134 136 -136
		mu 0 4 25 31 118 117
		f 4 -46 98 137 -135
		mu 0 4 31 24 104 118
		f 4 -49 139 140 -113
		mu 0 4 20 32 119 108
		f 4 -48 135 141 -140
		mu 0 4 32 25 117 119
		f 4 -58 142 143 -74
		mu 0 4 34 43 120 95
		f 4 -57 144 145 -143
		mu 0 4 43 33 121 120
		f 4 -59 68 148 -148
		mu 0 4 36 35 92 122
		f 4 -60 147 152 -151
		mu 0 4 37 36 122 123
		f 4 -61 150 156 -156
		mu 0 4 38 37 123 124
		f 4 -62 155 159 -159
		mu 0 4 39 38 124 125
		f 4 -64 161 163 -163
		mu 0 4 40 44 127 126
		f 4 -63 158 164 -162
		mu 0 4 44 39 125 127
		f 4 -66 166 168 -168
		mu 0 4 41 45 129 128
		f 4 -65 162 169 -167
		mu 0 4 45 40 126 129
		f 4 -67 167 173 -172
		mu 0 4 42 41 128 130
		f 4 -68 171 174 -145
		mu 0 4 33 42 130 121;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
createNode animCurveTU -n "pPlane7_visibility";
	rename -uid "7E87F1A2-4161-C509-9588-2FB4D00DFED3";
	setAttr ".tan" 9;
	setAttr ".ktv[0]"  1 1;
	setAttr ".kot[0]"  5;
createNode animCurveTL -n "pPlane7_translateX";
	rename -uid "836715F5-48AF-FC2D-9BFC-6DB1051C8EB2";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTL -n "pPlane7_translateY";
	rename -uid "D06A7F7E-4056-7DDD-EA0F-22AE0D073F5F";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 0.12856579910277055;
createNode animCurveTL -n "pPlane7_translateZ";
	rename -uid "7CF7AE80-455D-DDA5-AD31-93BC1268A5D2";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 -3.8019378061109079;
createNode animCurveTA -n "pPlane7_rotateX";
	rename -uid "D39DF110-4A1C-775C-881A-9D961269BF9D";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 89.779575088000897;
createNode animCurveTA -n "pPlane7_rotateY";
	rename -uid "6059DB67-4CDF-8ECC-4384-5C922595D40D";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTA -n "pPlane7_rotateZ";
	rename -uid "859EEA97-4C81-A5DB-0F48-389E4DB43C5A";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 0;
createNode animCurveTU -n "pPlane7_scaleX";
	rename -uid "228FC0DD-4D9F-F9F1-B33D-B7B813F905B1";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "pPlane7_scaleY";
	rename -uid "36F49FA0-4120-6722-4DFF-8F88552D6DE3";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 1;
createNode animCurveTU -n "pPlane7_scaleZ";
	rename -uid "C59FA2BF-478E-AC0E-86C1-1D9307D1F9AF";
	setAttr ".tan" 18;
	setAttr ".ktv[0]"  1 1;
createNode groupId -n "groupId10";
	rename -uid "6868F798-4660-F75E-EAFE-6D9FEF7C3E09";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert9SG";
	rename -uid "BF916114-475B-495E-CC36-A0AFC5FDE5E9";
	setAttr ".ihi" 0;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 2 ".gn";
createNode materialInfo -n "materialInfo9";
	rename -uid "08C87D59-4D5B-A50F-5A13-2F824ABCEBD7";
createNode lambert -n "lambert9";
	rename -uid "A8996E78-46F2-4B54-1673-57A7BBD69766";
createNode file -n "file8";
	rename -uid "1FE8DAE8-41B2-BBF0-E840-A1A2037DDDEE";
	setAttr ".ftn" -type "string" "C:/Users/Student/Documents/pocket-rocket-2/Assets/body textures/Feet Sub transparent.png";
	setAttr ".cs" -type "string" "sRGB";
createNode place2dTexture -n "place2dTexture15";
	rename -uid "D0247822-4C8D-9904-24B9-A5AD7D7C89FE";
createNode groupId -n "groupId12";
	rename -uid "4B67E215-4149-F678-4FB3-C5B08130DA9B";
	setAttr ".ihi" 0;
createNode shadingEngine -n "lambert11SG";
	rename -uid "72256DAC-4E76-BDE6-2015-509F143FB15E";
	setAttr ".ihi" 0;
	setAttr -s 3 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 4 ".gn";
createNode materialInfo -n "materialInfo11";
	rename -uid "8741039B-4DFC-AECF-17CF-D98F23852A94";
createNode lambert -n "lambert11";
	rename -uid "95B0C36A-4BDD-D255-9364-71B6F0479C1A";
createNode file -n "file10";
	rename -uid "DF4B4B5C-4B9A-B329-CEA4-2DA5C8A879AD";
	setAttr ".ftn" -type "string" "C:/Users/Student/Documents/pocket-rocket-2/Assets/body textures/Thorax Sub transparent.png";
	setAttr ".cs" -type "string" "sRGB";
createNode place2dTexture -n "place2dTexture17";
	rename -uid "C1DB7382-4004-FE21-2F1C-148556F5DCE9";
createNode groupId -n "groupId11";
	rename -uid "F16E3EE0-46A0-B81E-6B9E-4CA22A6B5EA0";
	setAttr ".ihi" 0;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "541F3878-49C8-92F6-769D-B8A99E167DC2";
	setAttr -s 8 ".lnk";
	setAttr -s 8 ".slnk";
select -ne :time1;
	setAttr ".o" 90;
	setAttr ".unw" 90;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 8 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 10 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
	setAttr -s 6 ".u";
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
	setAttr -s 6 ".tx";
select -ne :lambert1;
select -ne :initialShadingGroup;
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :initialMaterialInfo;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
select -ne :ikSystem;
	setAttr -s 4 ".sol";
connectAttr "pPlane7_visibility.o" "pPlane7.v";
connectAttr "pPlane7_translateX.o" "pPlane7.tx";
connectAttr "pPlane7_translateY.o" "pPlane7.ty";
connectAttr "pPlane7_translateZ.o" "pPlane7.tz";
connectAttr "pPlane7_rotateX.o" "pPlane7.rx";
connectAttr "pPlane7_rotateY.o" "pPlane7.ry";
connectAttr "pPlane7_rotateZ.o" "pPlane7.rz";
connectAttr "pPlane7_scaleX.o" "pPlane7.sx";
connectAttr "pPlane7_scaleY.o" "pPlane7.sy";
connectAttr "pPlane7_scaleZ.o" "pPlane7.sz";
connectAttr "groupId10.id" "pPlaneShape7.iog.og[0].gid";
connectAttr "lambert9SG.mwc" "pPlaneShape7.iog.og[0].gco";
connectAttr "groupId12.id" "pPlaneShape7.iog.og[1].gid";
connectAttr "lambert11SG.mwc" "pPlaneShape7.iog.og[1].gco";
connectAttr "groupId11.id" "pPlaneShape7.ciog.cog[0].cgid";
connectAttr "lambert9.oc" "lambert9SG.ss";
connectAttr "pPlaneShape7.iog.og[0]" "lambert9SG.dsm" -na;
connectAttr "pPlaneShape7.ciog.cog[0]" "lambert9SG.dsm" -na;
connectAttr "groupId10.msg" "lambert9SG.gn" -na;
connectAttr "groupId11.msg" "lambert9SG.gn" -na;
connectAttr "lambert9SG.msg" "materialInfo9.sg";
connectAttr "lambert9.msg" "materialInfo9.m";
connectAttr "file8.msg" "materialInfo9.t" -na;
connectAttr "file8.oc" "lambert9.c";
connectAttr "file8.ot" "lambert9.it";
connectAttr ":defaultColorMgtGlobals.cme" "file8.cme";
connectAttr ":defaultColorMgtGlobals.cfe" "file8.cmcf";
connectAttr ":defaultColorMgtGlobals.cfp" "file8.cmcp";
connectAttr ":defaultColorMgtGlobals.wsn" "file8.ws";
connectAttr "place2dTexture15.c" "file8.c";
connectAttr "place2dTexture15.tf" "file8.tf";
connectAttr "place2dTexture15.rf" "file8.rf";
connectAttr "place2dTexture15.mu" "file8.mu";
connectAttr "place2dTexture15.mv" "file8.mv";
connectAttr "place2dTexture15.s" "file8.s";
connectAttr "place2dTexture15.wu" "file8.wu";
connectAttr "place2dTexture15.wv" "file8.wv";
connectAttr "place2dTexture15.re" "file8.re";
connectAttr "place2dTexture15.of" "file8.of";
connectAttr "place2dTexture15.r" "file8.ro";
connectAttr "place2dTexture15.n" "file8.n";
connectAttr "place2dTexture15.vt1" "file8.vt1";
connectAttr "place2dTexture15.vt2" "file8.vt2";
connectAttr "place2dTexture15.vt3" "file8.vt3";
connectAttr "place2dTexture15.vc1" "file8.vc1";
connectAttr "place2dTexture15.o" "file8.uv";
connectAttr "place2dTexture15.ofs" "file8.fs";
connectAttr "lambert11.oc" "lambert11SG.ss";
connectAttr "pPlaneShape9.iog.og[0]" "lambert11SG.dsm" -na;
connectAttr "pPlaneShape9.ciog.cog[0]" "lambert11SG.dsm" -na;
connectAttr "pPlaneShape7.iog.og[1]" "lambert11SG.dsm" -na;
connectAttr "groupId1.msg" "lambert11SG.gn" -na;
connectAttr "groupId2.msg" "lambert11SG.gn" -na;
connectAttr "groupId9.msg" "lambert11SG.gn" -na;
connectAttr "groupId12.msg" "lambert11SG.gn" -na;
connectAttr "lambert11SG.msg" "materialInfo11.sg";
connectAttr "lambert11.msg" "materialInfo11.m";
connectAttr "file10.msg" "materialInfo11.t" -na;
connectAttr "file10.oc" "lambert11.c";
connectAttr "file10.ot" "lambert11.it";
connectAttr ":defaultColorMgtGlobals.cme" "file10.cme";
connectAttr ":defaultColorMgtGlobals.cfe" "file10.cmcf";
connectAttr ":defaultColorMgtGlobals.cfp" "file10.cmcp";
connectAttr ":defaultColorMgtGlobals.wsn" "file10.ws";
connectAttr "place2dTexture17.c" "file10.c";
connectAttr "place2dTexture17.tf" "file10.tf";
connectAttr "place2dTexture17.rf" "file10.rf";
connectAttr "place2dTexture17.mu" "file10.mu";
connectAttr "place2dTexture17.mv" "file10.mv";
connectAttr "place2dTexture17.s" "file10.s";
connectAttr "place2dTexture17.wu" "file10.wu";
connectAttr "place2dTexture17.wv" "file10.wv";
connectAttr "place2dTexture17.re" "file10.re";
connectAttr "place2dTexture17.of" "file10.of";
connectAttr "place2dTexture17.r" "file10.ro";
connectAttr "place2dTexture17.n" "file10.n";
connectAttr "place2dTexture17.vt1" "file10.vt1";
connectAttr "place2dTexture17.vt2" "file10.vt2";
connectAttr "place2dTexture17.vt3" "file10.vt3";
connectAttr "place2dTexture17.vc1" "file10.vc1";
connectAttr "place2dTexture17.o" "file10.uv";
connectAttr "place2dTexture17.ofs" "file10.fs";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert9SG.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "lambert11SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert9SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "lambert11SG.message" ":defaultLightSet.message";
connectAttr "lambert9SG.pa" ":renderPartition.st" -na;
connectAttr "lambert11SG.pa" ":renderPartition.st" -na;
connectAttr "lambert9.msg" ":defaultShaderList1.s" -na;
connectAttr "lambert11.msg" ":defaultShaderList1.s" -na;
connectAttr "place2dTexture15.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "place2dTexture17.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "file8.msg" ":defaultTextureList1.tx" -na;
connectAttr "file10.msg" ":defaultTextureList1.tx" -na;
// End of body.ma
