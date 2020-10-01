using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace OneSystemMonitor.EntityFrameworkCore
{
    public static class OneSystemMonitorDbContextModelCreatingExtensions
    {
        public static void ConfigureOneSystemMonitor(
            this ModelBuilder builder,
            Action<OneSystemMonitorModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OneSystemMonitorModelBuilderConfigurationOptions(
                OneSystemMonitorDbProperties.DbTablePrefix,
                OneSystemMonitorDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}