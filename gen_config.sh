GEN_JAR="../tool/perfect_gen.jar"
CSV_DIR="../cfg"
WORK_DIR="../client"
OUT_DIRGEN="Assets/Perfect/EditorConfig/Gen"
cd $WORK_DIR

java -Xms1g -cp $GEN_JAR perfect.gen.cfg.Main -xml ${CSV_DIR}/cfg_sc.xml -c $OUT_DIRGEN   -l cs -d Assets/Res/config -g client -e $OUT_DIRGEN