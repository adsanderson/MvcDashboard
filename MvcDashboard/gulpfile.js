/// <binding />
const gulp = require('gulp');

gulp.task('vendor:20:copy', function () {
    return gulp.src(
      [
          'node_modules/dashboardwidget/widget-component.ts',
      ])
      .pipe(gulp.dest('Scripts'));
});